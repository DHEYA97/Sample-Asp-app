using AutoMapper;
using Data.BL.Interfaces;
using Data.DL.Model;
using Data.PL.Consts;
using Data.PL.Filters;
using Data.PL.Helper;
using Data.PL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Data.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
       public IActionResult Index()
        {
            return RedirectToAction(nameof(List));
        }
        public async Task<IActionResult> List()
        {
            var employeeList = await _unitOfWork.EmployeeService.GetAllEmployeeAsync();
            var employeeVMList = _mapper.Map<IEnumerable<EmployeeVM>>(employeeList);
            return View(employeeVMList);
        }
        [HttpGet]
        [AjaxOnly]
        public IActionResult Create()
        {
            return PartialView("_Form",PrebareEmployeeFormViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeVM model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var employee = _mapper.Map<Employee>(model);
            employee.CreatedOn = DateTime.Now;
            if(model.SelectedDepartments.Count > 0)
                foreach (var dep in model.SelectedDepartments)
                {
                    employee.Departments.Add(new DepartmentEmployee { DepartmentId = dep });
                }
            if(model.ImageFile is not null)
            {
                employee.Image = await DocumentSetting.UploadImageAsync(model.ImageFile, SystemConst.ImagesPath);
            }
            await _unitOfWork.EmployeeService.AddEmployeeAsync(employee);
            await _unitOfWork.Complete();
            var empVM = _mapper.Map<EmployeeVM>(employee);
            return PartialView("_EmployeeRow", empVM);
        }
        [HttpGet]
        [AjaxOnly]
        public async  Task<IActionResult> Edit(int id)
        {
            var employees =await _unitOfWork.EmployeeService.GetAllEmployeeWithInclude("Departments");
            Employee employee = employees.SingleOrDefault(e=>e.Id == id);
            if (employee is null)
            {
                return NotFound();
            }
            var employeeVM = _mapper.Map<EmployeeVM>(employee);
            employeeVM.SelectedDepartments = employee.Departments.Select(d=>d.DepartmentId).ToList();
            return PartialView("_Form", PrebareEmployeeFormViewModel(employeeVM));
        }
        [HttpPost]
        [AjaxOnly]
        public async Task<IActionResult> Edit(EmployeeVM model)
        {
            if(!ModelState.IsValid)
               return BadRequest();

            var employees = await _unitOfWork.EmployeeService.GetAllEmployeeWithInclude("Departments");
            Employee employee = employees.SingleOrDefault(e => e.Id == model.Id);
            if (employee is null)
            {
                return NotFound();
            }
            if (model.ImageFile is not null)
            {
                if(!string.IsNullOrEmpty(employee.Image))
                DocumentSetting.DeleteFile(employee.Image, SystemConst.ImagesPath);

                model.Image = await DocumentSetting.UploadImageAsync(model.ImageFile, SystemConst.ImagesPath);
            }
            else if(!string.IsNullOrEmpty(employee.Image))
            {
                model.Image = employee.Image;
            }
            employee = _mapper.Map(model, employee);
            employee.LastUpdatedOn = DateTime.Now;
            if (model.SelectedDepartments.Count > 0)
                foreach (var dep in model.SelectedDepartments)
                {
                    employee.Departments.Add(new DepartmentEmployee { DepartmentId = dep });
                }
            await _unitOfWork.EmployeeService.UpdateEmployeeAsync(employee);
            await _unitOfWork.Complete();
            var EmpVM = _mapper.Map<EmployeeVM>(employee);
            return PartialView("_EmployeeRow", EmpVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var employee = await _unitOfWork.EmployeeService.GetEmployeeByIdAsync(Id);
            if (employee is null)
                return NotFound();
            employee.LastUpdatedOn = DateTime.Now;
            await _unitOfWork.EmployeeService.DeleteEmployeeAsync(employee);
            await _unitOfWork.Complete();
            return Ok(employee.LastUpdatedOn.ToString());
        }
        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Details(int id)
        {
            var employee = await _unitOfWork.EmployeeService.GetEmployeeByIdAsync(id);
            if (employee is null)
            {
                return NotFound();
            }
            var EmpVM = _mapper.Map<EmployeeVM>(employee);
            return PartialView("_Card", EmpVM);
        }
        private EmployeeVM PrebareEmployeeFormViewModel(EmployeeVM? model = null)
        {
            EmployeeVM viewModel = model ?? new EmployeeVM();
            var Department = _unitOfWork.DepartmentService.FilterDepartment(d=>d.IsDeleted != true);
            viewModel.Departments = _mapper.Map<IEnumerable<SelectListItem>>(Department);
            return viewModel;
        }
    }
}
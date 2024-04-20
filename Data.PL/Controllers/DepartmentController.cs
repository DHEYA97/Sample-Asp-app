using AutoMapper;
using Data.BL.Interfaces;
using Data.DL.Model;
using Data.PL.Filters;
using Data.PL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DepartmentController(IUnitOfWork unitOfWork, IMapper mapper)
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
            var departmentList = await _unitOfWork.DepartmentService.GetAllDepartmentAsync();
            var departmentVMList = _mapper.Map<IEnumerable<DepartmentVM>>(departmentList);
            return View(departmentVMList);
        }
        [HttpGet]
        [AjaxOnly]
        public IActionResult Create()
        {
            return PartialView("_Form");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentVM model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Department = _mapper.Map<Department>(model);
            Department.CreatedOn = DateTime.Now;
            await _unitOfWork.DepartmentService.AddDepartmentAsync(Department);
            await _unitOfWork.Complete();
            var DepVM = _mapper.Map<DepartmentVM>(Department);
            return PartialView("_DepartmentRow", DepVM);
        }
        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Edit(int id)
        {
            var Department = await _unitOfWork.DepartmentService.GetDepartmentByIdAsync(id);
            if(Department is null)
            {
                return BadRequest();
            }
            var DepartmentVM = _mapper.Map<DepartmentVM>(Department);
            return PartialView("_Form",DepartmentVM);
        }
        [HttpPost]
        [AjaxOnly]
        public async Task<IActionResult> Edit(DepartmentVM model)
        {
            if(!ModelState.IsValid)
               return BadRequest();
            
            var department = await _unitOfWork.DepartmentService.GetDepartmentByIdAsync(model.Id);
            if(department is null)
                return BadRequest();
            department = _mapper.Map(model, department);
            department.LastUpdatedOn = DateTime.Now;
            await _unitOfWork.DepartmentService.UpdateDepartmentAsync(department);
            await _unitOfWork.Complete();
            var DepartmentVM = _mapper.Map<DepartmentVM>(department);
            return PartialView("_DepartmentRow", DepartmentVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var department = await _unitOfWork.DepartmentService.GetDepartmentByIdAsync(Id);
            if (department is null)
                return NotFound();
            department.LastUpdatedOn = DateTime.Now;
            await _unitOfWork.DepartmentService.DeleteDepartmentAsync(department);
            await _unitOfWork.Complete();
            return Ok(department.LastUpdatedOn.ToString());
        }
        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Details(int id)
        {
            var Department = await _unitOfWork.DepartmentService.GetDepartmentByIdAsync(id);
            if (Department is null)
            {
                return BadRequest();
            }
            var DepartmentVM = _mapper.Map<DepartmentVM>(Department);
            return PartialView("_Card", DepartmentVM);
        }
    }
}
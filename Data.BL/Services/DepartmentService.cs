using Data.BL.Interfaces;
using Data.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Services
{
    public class DepartmentService : IDepartmentService
    {

        private readonly IRepository<Department> _departmentRepository;

        public DepartmentService(IRepository<Department> departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task AddDepartmentAsync(Department department)
        {
            await _departmentRepository.AddAsync(department);
        }

        public async Task DeleteDepartmentAsync(Department department)
        {
            var Dep = await _departmentRepository.GetByIdAsync(department.Id);
            if (Dep is not null)
            {
                _departmentRepository.Delete(department);
            }
        }

        public async Task<ICollection<Department>> GetAllDepartmentAsync()
        {
            var List = await _departmentRepository.GetAllAsync() ?? new List<Department>();
            return List;
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            var Dep = await _departmentRepository.GetByIdAsync(id) ?? new Department();
            return Dep;
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
            var Dep = await _departmentRepository.GetByIdAsync(department.Id);
            if (Dep is not null)
            {
                _departmentRepository.Update(department);
            }
        }
        public IEnumerable<Department> FilterDepartment(Func<Department, bool> predicate)
        {
            return _departmentRepository.Filter(predicate);
        }
        public IEnumerable<TResult> SelectDepartment<TResult>(Func<Department, TResult> selector)
        {
            return _departmentRepository.Select(selector);
        }
        public async Task<IEnumerable<Department>> GetAllDepartmentWithInclude(params string[] includes)
        {
            return await _departmentRepository.GetAllWithInclude(includes);
        }
    }
}

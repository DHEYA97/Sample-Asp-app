using Data.BL.Interfaces;
using Data.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> EmployeeRepository)
        {
            _employeeRepository = EmployeeRepository;
        }

        public async Task AddEmployeeAsync(Employee Employee)
        {
           await _employeeRepository.AddAsync(Employee);
        }

        public async Task DeleteEmployeeAsync(Employee Employee)
        {
            var emp = await _employeeRepository.GetByIdAsync(Employee.Id);
            if (emp is not null)
            {
                _employeeRepository.Delete(Employee);
            }
        }

        public async Task<ICollection<Employee>> GetAllEmployeeAsync()
        {
            var List = await _employeeRepository.GetAllAsync() ?? new List<Employee>();
            return List;
        }
        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var emp = await _employeeRepository.GetByIdAsync(id) ?? new Employee();
            return emp;
        }

        public async Task UpdateEmployeeAsync(Employee Employee)
        {
            var emp = await _employeeRepository.GetByIdAsync(Employee.Id);
            if (emp is not null)
            {
              _employeeRepository.Update(Employee);
            }
        }
        public IEnumerable<Employee> FilterEployee(Func<Employee, bool> predicate)
        {
            return _employeeRepository.Filter(predicate);
        }
        public IEnumerable<TResult> SelectEmployee<TResult>(Func<Employee, TResult> selector)
        {
            return _employeeRepository.Select(selector);
        }
        public async Task<IEnumerable<Employee>> GetAllEmployeeWithInclude(params string[] includes)
        {
            return await _employeeRepository.GetAllWithInclude(includes);
        }
    }
}

using Data.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Interfaces
{
    public interface IEmployeeService
    {
        Task<ICollection<Employee>> GetAllEmployeeAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(Employee department);
        Task DeleteEmployeeAsync(Employee department);
        Task UpdateEmployeeAsync(Employee department);
        IEnumerable<Employee> FilterEployee(Func<Employee, bool> predicate);
        IEnumerable<TResult> SelectEmployee<TResult>(Func<Employee, TResult> selector);
        Task<IEnumerable<Employee>> GetAllEmployeeWithInclude(params string[] includes);
    }
}

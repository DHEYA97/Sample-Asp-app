using Data.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Interfaces
{
    public interface IDepartmentService
    {
        Task<ICollection<Department>> GetAllDepartmentAsync();
        Task<Department> GetDepartmentByIdAsync(int id);
        Task AddDepartmentAsync(Department department);
        Task DeleteDepartmentAsync(Department department);
        Task UpdateDepartmentAsync(Department department);
        IEnumerable<Department> FilterDepartment(Func<Department, bool> predicate);
        IEnumerable<TResult> SelectDepartment<TResult>(Func<Department, TResult> selector);
        Task<IEnumerable<Department>> GetAllDepartmentWithInclude(params string[] includes);
    }
}

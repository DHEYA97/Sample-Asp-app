using Data.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Interfaces
{
    public interface IUnitOfWork
    {
        public IDepartmentService DepartmentService { get; }
        public IEmployeeService EmployeeService { get;}
        public Task<int> Complete();
    }
}

using Data.BL.Interfaces;
using Data.DL.Data;
using Data.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Services
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Department> _departmentRepository;
        private readonly IRepository<Employee> _employeeRepository;
        
        private IDepartmentService departmentService;
        private IEmployeeService employeeService;
        public UnitOfWork(ApplicationDbContext context, IRepository<Department> departmentRepository, IRepository<Employee> employeeRepository)
        {
            _context = context;
            _departmentRepository = departmentRepository;
            _employeeRepository = employeeRepository;
            departmentService = new DepartmentService(_departmentRepository);
            employeeService = new EmployeeService(_employeeRepository);
        }
        public IDepartmentService DepartmentService => departmentService;
        public IEmployeeService EmployeeService => employeeService;
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

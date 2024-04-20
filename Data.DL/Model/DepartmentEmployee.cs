using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DL.Model
{
    public class DepartmentEmployee
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}

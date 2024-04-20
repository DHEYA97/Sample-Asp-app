using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DL.Model
{
    public class Department : BaseEntitiy
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<DepartmentEmployee> Employees { get; set; } = new List<DepartmentEmployee>();
    }
}

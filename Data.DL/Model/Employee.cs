using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DL.Model
{
    public class Employee : BaseEntitiy
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary {  get; set; }
        public string? Image { get; set; }
        public int? Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime HiaringDate { get; set; }
        public ICollection<DepartmentEmployee> Departments {  get; set; } = new List<DepartmentEmployee>();
    }
}
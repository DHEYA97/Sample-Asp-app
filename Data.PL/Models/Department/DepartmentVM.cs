using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace Data.PL.Models
{
    public class DepartmentVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is Required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [DisplayName("Date Of Creation")]
        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}

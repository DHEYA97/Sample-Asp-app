using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using Data.PL.Consts;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Data.PL.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = Errors.Required)]
        public string Name { get; set; }
        [RegularExpression(@"[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$",ErrorMessage =Errors.Adress)]
        public string Adress { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Image { get; set; }
        public IFormFile? ImageFile { get; set; }
        [Range(15, 100, ErrorMessage = Errors.AgeRange)]
        public int? Age { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [DisplayName("Hiaring Date")]
        public DateTime HiaringDate { get; set; } = DateTime.Now;
        [DisplayName("Date Of Creation")]
        public DateTime? CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public IList<int> SelectedDepartments { get; set;} = new List<int>();
        public IEnumerable<SelectListItem>? Departments { get; set; }
    }
}

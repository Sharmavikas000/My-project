using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public class Employee
    {
        [Key]
        public virtual int? EmpId { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        public virtual string Empname { get; set; }

        [Required]
        [Display(Name = "Salary")]
        public virtual int? EmpSal { get; set; }

        [Required]
        [Display(Name = "City")]
        public virtual string EmpCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public virtual string EmpState { get; set; }
    }
}

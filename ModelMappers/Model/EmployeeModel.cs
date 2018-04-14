using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Web.Mvc;


namespace ModelMappers.Model
{
    public class EmployeeModel
    {
        public IList<Employee> Employees { get; set; }
        public Employee Employee {get;set;}

        public IList<State> States { get; set; }

        public IList<SelectListItem> StateDropDownList { get; set; }
        public string State { get; set; }
    }
}

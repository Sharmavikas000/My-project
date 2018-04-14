using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Domain;
using ModelMappers;
using BusinessManagers;
using BusinessManagers.Interfaces;
using ModelMappers.Model;


namespace UserController
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeManager _employeeManager;
        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }
        [HttpGet]
        public ActionResult Index(int? id)
        {
            try
            {
                var empModel = new EmployeeModel();
                if (id.HasValue)
                    empModel.Employee = _employeeManager.GetById(id.Value);

                empModel.Employees = _employeeManager.GetAllEmployee();


                empModel.States = _employeeManager.GetAllStates();
                empModel.StateDropDownList = empModel.States.Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName.ToString()
                }).ToList();
                return View(empModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult Index(EmployeeModel empModel)
        {
            Employee emp = new Employee();
            State state = new State();
            if (empModel.Employee.EmpId > 0)
            {
                emp.Empname = empModel.Employee.Empname;
                emp.EmpSal = empModel.Employee.EmpSal;
                emp.EmpCity = empModel.Employee.EmpCity;
                emp.EmpId = empModel.Employee.EmpId;
                emp.EmpState = empModel.State;
                _employeeManager.Update(emp);
            }
            else
            {
                emp.Empname = empModel.Employee.Empname;
                emp.EmpSal = empModel.Employee.EmpSal;
                emp.EmpCity = empModel.Employee.EmpCity;
                emp.EmpState = empModel.State;
                if (ModelState.IsValid)
                {
                    _employeeManager.AddEmployee(emp);
                }
            }
            empModel.Employees = _employeeManager.GetAllEmployee();
            return View(empModel);

            
        }
        [HttpPost]
        public JsonResult IndexJquery(EmployeeModel empModel)
        {
            Employee emp = new Employee();
            if (empModel.Employee.EmpId > 0)
            {
                emp.Empname = empModel.Employee.Empname;
                emp.EmpSal = empModel.Employee.EmpSal;
                emp.EmpCity = empModel.Employee.EmpCity;
                emp.EmpId = empModel.Employee.EmpId;
                _employeeManager.Update(emp);
            }
            else
            {
                emp.Empname = empModel.Employee.Empname;
                emp.EmpSal = empModel.Employee.EmpSal;
                emp.EmpCity = empModel.Employee.EmpCity;
                if (ModelState.IsValid)
                {
                    //empModel.Employees.Add(emp);
                    _employeeManager.AddEmployee(emp);

                }
            }
            empModel.Employees = _employeeManager.GetAllEmployee();
            return Json(true);



        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                _employeeManager.DeleteEmployee(id);
            }
            return RedirectToAction("Index");
        }
    }
}

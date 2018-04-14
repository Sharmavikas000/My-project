using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagers.Interfaces;
using Domain;
using Repository;
using System.Web.Mvc;

namespace BusinessManagers
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IRepository<Employee> _employeeDAO;
        private readonly IRepository<State> _stateDAO;
        public EmployeeManager(IRepository<Employee> employeeDAO, IRepository<State> stateDAO)
        {
            _employeeDAO = employeeDAO;
            _stateDAO = stateDAO;
        }

        public IList<Employee> GetAllEmployee()
        {
            return _employeeDAO.FetchAll();
        }
        public IList<State> GetAllStates()
        {
            return _stateDAO.FetchAll();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employeeDAO.Insert(employee);
            }
        }

        public void DeleteEmployee(int id)
        {
            if (id > 0)
            {
                var employee = _employeeDAO.Table.Where(x => x.EmpId == id).FirstOrDefault();
                _employeeDAO.Delete(employee);
            }
        }
        public Employee GetById(int id)
        {
            return _employeeDAO.Table.Where(x => x.EmpId == id).FirstOrDefault();

        }
        public void Update(Employee employee)
        {
            if (employee != null)
            {
                _employeeDAO.Update(employee);
            }

        }
    }
}

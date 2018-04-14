using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
using System.Web.Mvc;


namespace BusinessManagers.Interfaces
{
    public interface IEmployeeManager
    {
        IList<Employee> GetAllEmployee();
        IList<State> GetAllStates();
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        void Update(Employee employee);
        Employee GetById(int id);
    }
}

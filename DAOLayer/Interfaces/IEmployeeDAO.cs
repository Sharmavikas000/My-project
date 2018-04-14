using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace DAOLayer.Interfaces
{
    public interface IEmployeeDAO
    {
        IList<Employee> GetAll(Employee employee);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee GetById(int id, Employee employee);
        
    }
}

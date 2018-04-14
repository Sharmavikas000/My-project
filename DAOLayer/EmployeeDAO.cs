using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOLayer.Interfaces;
using Domain;
using Repository;

namespace DAOLayer
{
    public class EmployeeDAO : IEmployeeDAO
    {
        public IList<Employee> GetAll(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Services
{
    public interface IEmployeeService
    {

        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee model);
        Employee EditEmployee(int EmployeeId);
        void EditEmployee(Employee model);
        Employee DeleteEmployee(int EmployeeId);
        void Delete(int EmployeeID);
    }
}

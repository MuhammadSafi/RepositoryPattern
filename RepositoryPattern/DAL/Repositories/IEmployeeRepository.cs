using RepositoryPattern.DAL;
using RepositoryPattern.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPattern.Repositories.DAL
{
    public interface  IEmployeeRepository :IRepository<Employee>
    {


        //IEnumerable<Employee> GetAll();
        //Employee GetById(int EmployeeID);
        //void Insert(Employee employee);
        //void Update(Employee employee);
        void Delete(int EmployeeID);
        //void Save();
    }
}
using RepositoryPattern.DAL;
using RepositoryPattern.DAL.DTOBuilder;
using RepositoryPattern.DAL.Repositories;
using RepositoryPattern.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPattern.Repositories.DAL
{
    public class EmployeeRepository : Repository<Employee>
    {
     
        public EmployeeRepository(EmployeeDBContext context) : base(context)
        {
         
        }

        public void Delete(int EmployeeID)
        {
            //Employee employee = _context.Employees.Find(EmployeeID);
            //_context.Employees.Remove(employee);
        }

        //public void Save()
        //{
        //    _context.SaveChanges();
        //}
        
    }
}
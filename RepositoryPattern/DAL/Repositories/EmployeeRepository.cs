using RepositoryPattern.DAL;
using RepositoryPattern.DAL.DTOBuilder;
using RepositoryPattern.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPattern.Repositories.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _context;

        public EmployeeRepository()
        {
            _context = new EmployeeDBContext();
        }


        public EmployeeRepository(EmployeeDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            var lists= _context.Employees.ToList();


            lists.OrderByDescending(p => p.EmployeeID)
                           .Select(p => EmployeeDtoBuilder.Build(p));
            return lists;
        }

        public Employee GetById(int EmployeeID)
        {
            return _context.Employees.Find(EmployeeID);
        }

        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
        public void Delete(int EmployeeID)
        {
            Employee employee = _context.Employees.Find(EmployeeID);
            _context.Employees.Remove(employee);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }
}
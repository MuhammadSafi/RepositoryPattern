using RepositoryPattern.DTO;
using RepositoryPattern.Repositories.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPattern.DAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _IEmployeeRepository;

        public EmployeeService() { }
        public EmployeeService(IEmployeeRepository IEmployeeRepository)
        {
            _IEmployeeRepository = IEmployeeRepository;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {

            var model = _IEmployeeRepository.GetAll();
            return model;

        }

        public void AddEmployee(Employee model)
        {

            _IEmployeeRepository.Insert(model);
            _IEmployeeRepository.Save();
        }

        public Employee EditEmployee(int EmployeeId)
        {

            var model = _IEmployeeRepository.GetById(EmployeeId);
            return model;

        }

        public void EditEmployee(Employee model)
        {
            _IEmployeeRepository.Update(model);
            _IEmployeeRepository.Save();
        }

        public Employee DeleteEmployee(int EmployeeId)
        {

            var model = _IEmployeeRepository.GetById(EmployeeId);
            return model;
        }

        public void Delete(int EmployeeId)
        {

            _IEmployeeRepository.Delete(EmployeeId);
            _IEmployeeRepository.Save();
        }
    }
}
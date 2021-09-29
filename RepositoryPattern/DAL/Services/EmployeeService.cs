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
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {

            var model = _employeeRepository.GetAll();
            return model;

        }

        public void AddEmployee(Employee model)
        {

            _employeeRepository.Insert(model);
            _employeeRepository.Save();
        }

        public Employee EditEmployee(int EmployeeId)
        {

            var model = _employeeRepository.GetById(EmployeeId);
            return model;

        }

        public void EditEmployee(Employee model)
        {
            _employeeRepository.Update(model);
            _employeeRepository.Save();
        }

        public Employee DeleteEmployee(int EmployeeId)
        {

            var model = _employeeRepository.GetById(EmployeeId);
            return model;
        }

        public void Delete(int EmployeeId)
        {

            _employeeRepository.Delete(EmployeeId);
            _employeeRepository.Save();
        }
    }
}
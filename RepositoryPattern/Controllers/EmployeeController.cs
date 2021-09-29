
using RepositoryPattern.DAL;
using RepositoryPattern.DAL.Services;
using RepositoryPattern.Repositories.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPattern.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeRepository = new EmployeeRepository(new EmployeeDBContext());
            _employeeService = new EmployeeService(_employeeRepository);
        }
        public EmployeeController(IEmployeeRepository employeeRepository, IEmployeeService employeeService)
        {
            _employeeRepository = employeeRepository;
            _employeeService = employeeService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _employeeService.GetAllEmployees();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.AddEmployee(model);
                 return RedirectToAction("Index", "Employee");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            var model = _employeeService.EditEmployee(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.EditEmployee(model);
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            Employee model = _employeeService.DeleteEmployee(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            _employeeService.Delete(EmployeeID);
            return RedirectToAction("Index", "Employee");
        }
    }
}
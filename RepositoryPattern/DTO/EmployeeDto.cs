using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPattern.DTO
{
    public class EmployeeDto
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
        public string Dept { get; set; }
    }
}
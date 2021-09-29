using RepositoryPattern.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPattern.DAL.DTOBuilder
{
    public class EmployeeDtoBuilder
    {
        public static EmployeeDto Build(Employee p)
        {

            var dto = new EmployeeDto
            {
                EmployeeID = p.EmployeeID,
                Name = p.Name,
                Gender = p.Gender,
                Salary = p.Salary,
                Dept = p.Dept

            };

            return dto;

        }
    }
}
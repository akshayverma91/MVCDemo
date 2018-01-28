using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.DataAccessLayer;

namespace MVCDemo.Models
{
    public class EmployeeBusinessLayer
    {


        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL saleDAL = new SalesERPDAL();
            saleDAL.Employees.Add(e);
            saleDAL.SaveChanges();
            return e;
        }

        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "Akshay";
            emp.LastName = "verma";
            emp.Salary = 40000;
            employees.Add(emp);

            Employee emp1 = new Employee();
            emp1.FirstName = "robert";
            emp1.LastName = "pattinson";
            emp1.Salary = 110000;
            employees.Add(emp1);

            Employee emp3 = new Employee();
            emp3.FirstName = "josep";
            emp3.LastName = "stalin";
            emp3.Salary = 20000;
            employees.Add(emp3);

            return employees;
        }

        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
        
    }
}
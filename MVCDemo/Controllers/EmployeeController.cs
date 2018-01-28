using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.ViewModel;
using MVCDemo.DataAccessLayer;

namespace MVCDemo.Controllers
{

    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }


        public override string ToString()
        {
            return this.CustomerName + " lives At " + this.Address ;
        }
    }

    

    public class EmployeeController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
            //if (1 == 1)
            //{
            //    return View("YourView");
            //}  
            //else
            //{   
            //    return View("MyView");
            //}
        //    return View("MyView");
        //}
        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee item in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = item.FirstName + " " + item.LastName;
                empViewModel.Salary = item.Salary;
                if(item.Salary > 21000)
                {
                    empViewModel.SalaryColor = "Yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "Green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            return View("Index", employeeListViewModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        //public string SaveEmployee(Employee e)
        //{
        //    return e.FirstName + "|" + e.LastName + "|" + e.Salary;
        //}

        //public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        //{
        //    switch(BtnSubmit)
        //    {
        //        case "Save Employee":
        //            return Content(e.FirstName + " | " + e.LastName + "Salary is " + e.Salary);
        //        case "Cancel":
        //            return RedirectToAction("Index");
        //    }
        //    return new EmptyResult();
        //}

        //public ActionResult SaveEmployee()
        //{
        //    Employee e = new Employee();
        //    e.FirstName = Request.Form["FirstName"];
        //    e.LastName = Request.Form["LastName"];
        //    e.Salary = int.Parse(Request.Form["Salary"]);
        //    return Content(e.FirstName + e.LastName + e.Salary);
        //}

        //public ActionResult SaveEmployee(Employee e)
        //{
        //    SalesERPDAL saleDAL = new SalesERPDAL();
        //    saleDAL.Employees.Add(e);
        //    saleDAL.SaveChanges();
        //    //return View("Index");
        //    return RedirectToAction("Index");

        //}


        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if(ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        //UpdateModel<Employee>(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("CreateEmployee");
                    }
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }

        public ActionResult GetVM()
        {
            Employee emp = new Employee();
            emp.FirstName = "Akshay";
            emp.LastName = "Verma";
            emp.Salary = 18000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary;
            if(emp.Salary>15000)
            {
                vmEmp.SalaryColor = "Yellow";
            }
            else
            {
                vmEmp.SalaryColor = "Green";
            }

            //vmEmp.UserName = "Admin";
            return View("MyView",vmEmp);
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Akshay";
            emp.LastName = "Verma";
            emp.Salary = 18000;
            //ViewData["Employee"] = emp;
            //return View("MyView");
            //ViewBag.Employee = emp;

            
            return View("MyView",emp);
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Akshay";
            c.Address = "JanakPuri";
            return c;
        }

        public string GetString()
        {
            return "Hello world this is my 3 or 4 attemp to learn MVC, Goona Complete it for sure!!!";
        }

        [NonAction]
       public string SimpleMethod()
        {
            return "test Non Action Method!";
        }


        //public ActionResult SaveEmployee([ModelBinder(typeof(MyEmployeeModelBinder))] Employee e, string BtnSubmit)
        //{
        //    switch (BtnSubmit)
        //    {
        //        case "Save Employee":
        //            return Content(e.FirstName + " | " + e.LastName + " Salary is " + e.Salary);
        //        case "Cancel":
        //            return RedirectToAction("Index");
        //    }
        //    return new EmptyResult();
        //}
    }

    //public class MyEmployeeModelBinder : DefaultModelBinder
    //{
    //    protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
    //    {
    //        Employee e = new Employee();
    //        e.FirstName = controllerContext.RequestContext.HttpContext.Request.Form["FirstName"];
    //        e.LastName= controllerContext.RequestContext.HttpContext.Request.Form["LastName"];
    //        e.Salary = int.Parse(controllerContext.RequestContext.HttpContext.Request.Form["Salary"]);
    //        return e;
    //        //return base.CreateModel(controllerContext, bindingContext, modelType);
    //    }
    //}
}
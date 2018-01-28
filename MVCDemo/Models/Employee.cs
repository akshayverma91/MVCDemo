using MVCDemo.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        //[Required(ErrorMessage="Enter First Name")]
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(5,ErrorMessage="Not Greater than 5 Length")]
        public string LastName { get; set; }
        public int Salary { get; set; }
    }

    
}
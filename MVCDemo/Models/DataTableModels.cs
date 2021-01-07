using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("tblEmployees")]
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public string JobTitle { get; set; }
            public string WebSite { get; set; }
            public int Salary { get; set; }
            public DateTime HireDate { get; set; }
        }


    
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{

    public class Student
    {
        [Display(Name ="User Name")]
        [Required(ErrorMessage ="{0} is required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        [StringLength(18,ErrorMessage = "{0} must be {2} to {1} characters long", MinimumLength = 6)]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        [CompareAttribute("Password", ErrorMessage = "The Password and Confirm Password fields did not match.")]
        public string  ConfirmPassword { get; set; }


        [DataType(DataType.Date)]        
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]      
        public DateTime DataOfBirth { get; set; }


        [Display(Name = "Email Id")]       
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "Invalid email")]
        public string EmailId { get; set; }
    }
}
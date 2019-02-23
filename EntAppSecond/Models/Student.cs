using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class Student
    {

        [Required(ErrorMessage = "Student ID must start with S and folowed by 7 digits")]
        [RegularExpression(@"(s|S)\d{7}")]          
        [Display(Name = "Student ID")]
        public string StudentID { get; set; } = "";

        [Required]
        [RegularExpression(@"\w{2,50}")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Display(Name = "Last Name")]
        [Required]
        [RegularExpression(@"\w{3,50}")]
        public string LastName { get; set; } = "";

        [Display(Name = "Date of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [Range(2,100)]
        [Display(Name = "Number of Module")]
        [Required]
        public byte NumberOfModule { get; set; }

        [Range(50, 250)]
        [Display(Name = "Hight in cm")]
        [Required]
        public byte Height { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression(@"[\w-]+@([\w-]+\.)+[\w-]+")]
        public string Email { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression(@"[\w-]+@([\w-]+\.)+[\w-]+")]
        public string EmailConfirm { get; set; }

        [Required]
       [GraduationCohort]
       public string GraduationCohort { get; set; }
    }



}

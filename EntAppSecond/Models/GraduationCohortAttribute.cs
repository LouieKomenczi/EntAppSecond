﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class GraduationCohortAttribute: ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object GraduationCohort, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;

            if (student.GraduationCohort != "Autumn" && student.GraduationCohort != "Spring")
            {
                return new ValidationResult("Must be Spring or Autumn");
            }

            return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-student", "Must be Spring or Autumn");
        }
    }
}

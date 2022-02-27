using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace GameMVC.Models
{
    public class SexValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var player = (Player) validationContext.ObjectInstance;

            if (player.Sex == "M" || player.Sex == "F")
                return ValidationResult.Success;
            else
                return new ValidationResult("Introduce (M) Male or (F) Female");
        }
    }
}
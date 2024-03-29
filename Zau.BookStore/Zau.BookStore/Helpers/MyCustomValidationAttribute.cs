﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zau.BookStore.Helpers
{
    public class MyCustomValidationAttribute : ValidationAttribute
    {

        public string Text { get; set; }

        public MyCustomValidationAttribute(string text)
        {
            Text = text;
        }


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string bookName = value.ToString();
                if (bookName.Contains(Text))
                {
                    return ValidationResult.Success;
                }

            }
            return new ValidationResult(ErrorMessage ?? "Book Name does not contains the desired value");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zau.BookStore.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name ="Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}

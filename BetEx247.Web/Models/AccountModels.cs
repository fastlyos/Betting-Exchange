﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using BetEx247.Data.Model;

namespace BetEx247.Web.Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        public RegisterModel()
        {
        }

        [Required(ErrorMessage = "You must enter a nick name for this service!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Nick Name")]
        public string NickName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Comfirm Password")]
        public string ComfirmPassword { get; set; }

        [Required]
        [Display(Name = "Security Question 1")]
        public string SecurityQuestion1 { get; set; }

        [Required]
        [Display(Name = "Security Answer 1")]
        public string SecurityAnswer1 { get; set; }
                           
        [Display(Name = "Security Question 2")]
        public string SecurityQuestion2 { get; set; }
                           
        [Display(Name = "Security Answer 2")]
        public string SecurityAnswer2 { get; set; }

        [Required]
        [Display(Name = "Currency")]
        public IEnumerable<SelectListItem> Currency { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Display(Name = "Cellphone")]
        public string Cellphone { get; set; }

        [Required]
        [Display(Name = "Country")]
        public IEnumerable<SelectListItem> Country { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email 2")]
        public string Email2 { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public IEnumerable<SelectListItem> Gender { get; set; }  
     
        [Display(Name = "Suffix")]
        public string Suffix { get; set; }

        [Display(Name = "Betting Region")]
        public string BettingRegion { get; set; } 
    
        [Display(Name = "Timezone")]
        public string Timezone { get; set; }            
    }
}

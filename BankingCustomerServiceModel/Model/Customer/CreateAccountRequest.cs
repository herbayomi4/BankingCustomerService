using BankingCustomerServiceModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BankingCustomerServiceModel.Models.Customer
{
    public class CreateAccountRequest
    {
        
        [Display(Name = "Accounut Type")]
        public AccountType accountType { get; set; }               
        public Name name { get; set; }
        public string gender { get; set; }
        public string DOB { get; set; }
        public Address address { get; set; }
        
    }

    public class Name
    {
        
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First Name length can't be more than 50.")]
        public string firstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(50, ErrorMessage = "Middle Name length can't be more than 50.")]
        public string middleName { get; set; }

        
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last Name length can't be more than 50.")]
        public string lastName { get; set; }

    }

    public class Address
    {
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Contact")]
        [StringLength(11, ErrorMessage = "Contact can't be more than 11 digits.")]
        public string contact { get; set; }

        [Display(Name = "Home Address")]
        [StringLength(50, ErrorMessage = "Home Address length can't be more than 50.")]
        public string address { get; set; }

        [Display(Name = "City")]
        [StringLength(50, ErrorMessage = "City Name length can't be more than 50.")]
        public string city { get; set; }

        [Display(Name = "State")]
        [StringLength(50, ErrorMessage = "State Name length can't be more than 50.")]
        public string state { get; set; }

        [Display(Name = "Country")]
        [StringLength(50, ErrorMessage = "Country Name length can't be more than 50.")]
        public string country { get; set; }
    }
}

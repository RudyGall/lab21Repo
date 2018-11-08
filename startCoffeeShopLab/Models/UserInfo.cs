using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace startCoffeeShopLab.Models
{
    public class UserInfo
        {
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            Password = "";
        }
        public UserInfo(string firstName, string lastName, string email, string phoneNumber, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }
            [Required]
            [RegularExpression("^[a-zA-Z]{2,}$")]
            public string FirstName { set; get; }

            [Required]
            [RegularExpression(@"^[a-zA-Z]{2,}$")]
            public string LastName { set; get; }
           
            [Required]
            [RegularExpression(@"^[A-z0-9]{5,30}(@)(.+){5,10}$")]
            public string Email { set; get; }

            [Required]
            [RegularExpression(@"^\d{10}$")]
            public string PhoneNumber { set; get; }

            [Required]
            [RegularExpression(@"^[a-zA-Z]\w{3,14}$")]
            public string Password { set; get; }
    }
    }
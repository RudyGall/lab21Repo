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
            Date = "";
            Age = "";
            Human = "";
        }
        public UserInfo(string firstName, string lastName, string email, string phoneNumber, string password, string date, string age, string human)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            Date = date;
            Age = age;
            Human = human;
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

            [Required]
            [RegularExpression(@"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$")]
            public string Date { set; get; }

            [Required]
            [RegularExpression(@"^$")]
            public string Age { set; get; }

            [Required]
            [RegularExpression(@"^$")]
            public string Human { set; get; }
    }
    }
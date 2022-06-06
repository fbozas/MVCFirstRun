using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFirstRun.Models
{
    public class User
    {
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(15, ErrorMessage = "UserName cannot be more than 15 characters")]
        public string UserName { get; set; }
        public string NewPassword { get; set; }
        public string ConfrimPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PostalCode { get; set; }
        public string Profile { get; set; }
        public string Photo { get; set; }
        public string AddtionalComments { get; set; }
        public string City { get; set; }
    }
}
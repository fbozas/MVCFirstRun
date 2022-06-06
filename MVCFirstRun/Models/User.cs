using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCFirstRun.Models
{
    public class User : IValidatableObject
    {
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(15, ErrorMessage = "UserName cannot be more than 15 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [StringLength(11, MinimumLength = 5, ErrorMessage = "Minimum Length of password is 5 letters or Max Length is of 11 letters")]
        [DataType("password")]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match")]
        public string ConfrimPassword { get; set; }

        [Required(ErrorMessage = "Date of Birth is Required")]
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Postal Code is Required")]
        [Range(10000,99999 , ErrorMessage = "Must be between 10000 and 99999")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Profile is required")]
        [DataType(DataType.MultilineText)]
        public string Profile { get; set; }

        [FileExtensions(Extensions ="jpg,jpeg,gif")]
        public string Photo { get; set; }

        [System.Web.Mvc.AllowHtml]
        [Display(Name = "Additional Comments")]
        public string AddtionalComments { get; set; }
        public string City { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            ValidationResult vr = null;

            if(City.ToLower() == "koridallos" && PostalCode != 18120)
            {
                vr = new ValidationResult("Invalid PostalCode for Koridallos City");
            }

            if (City.ToLower() == "nikaia" && PostalCode != 18454)
            {
                vr = new ValidationResult("Invalid PostalCode for Nikaia City");
            }

            return new List<ValidationResult>() { vr };
        }
    }
}
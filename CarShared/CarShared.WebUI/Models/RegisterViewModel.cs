using CarShared.DAL.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShared.WebUI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First Name is a Required field.")]
        [DataType(DataType.Text)]
        [Display(Name = "FirstName")]
        [MaxLength(80)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a Required field.")]
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        [MaxLength(80)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Your Gender is a Required.")]
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Adress { get; set; }
        [Required(ErrorMessage = "Your Age is a Required .")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }

    }
}

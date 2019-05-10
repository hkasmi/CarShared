using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CarShared.DAL.Entities
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
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
        [Required(ErrorMessage = "Your Gender is a Required.")]
        [Display(Name = "Gender")]
        public int Gender { get; set; }
        public string Adress { get; set; }
        [Required(ErrorMessage = "Your Age is a Required .")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }


    }
}
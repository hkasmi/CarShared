using CarShared.DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace CarShared.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>  //TODO Rename DbTripsContext
    {
        public ApplicationDbContext()
            : base("name=CarSharedDB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Trip> Trips {get;set;}
        public DbSet<City> Cities { get; set; }
    }
}
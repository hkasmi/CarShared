using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.DAL.Entities
{
    public class DbTripsContext : DbContext
    {
        public DbTripsContext() : base("name=CarShared")
        {

        }

        public DbSet<Trip> Trips { get; set; }

    }
}

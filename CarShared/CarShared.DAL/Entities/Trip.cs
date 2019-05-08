using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarShared.DAL.Entities
{
    public class Trip
    {
        public int TripId { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }

        public int IdDriver { get; set; }

        public DateTime Time { get; set; }

        public int SpotNumber { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
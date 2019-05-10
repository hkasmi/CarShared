using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.Shared.BTO
{
    public class TripBTO
    {
        public int tripId { get; set; }
        public string departureCity { get; set; }
        public string arrivalCity { get; set; }

        public DateTime TripDate { get; set; }
        public int NumberOfSpots { get; set; }

        public decimal price { get; set; }

        public string description { get; set; }
    }
}

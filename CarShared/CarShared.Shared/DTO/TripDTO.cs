using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.Common.DTO
{
    public class TripDTO
    {
        public int IdTrip { get; set; }
        public string departureCity { get; set; }
        public string arrivalCity { get; set; }

        public DateTime time { get; set; }
        public int spotNumber { get; set; }

        public decimal price { get; set; }

        public string description { get; set; }
    }
}

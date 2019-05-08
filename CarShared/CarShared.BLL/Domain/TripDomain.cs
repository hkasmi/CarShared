using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.BLL.Domain
{
    public class TripDomain
    {
        private int tripId;
        private string departureCity;
        private string arrivalCity;
        private int spotNumber;
        private decimal price;
        public TripDomain(int pTripId, string pDepartureCity, string pArrivalCity, int pSpotNumber, decimal pPrice )
        {
            TripId = pTripId;
            DepartureCity = pDepartureCity;
            ArrivalCity = pArrivalCity;
            SpotNumber = pSpotNumber;
            Price = pPrice;
        }

        public int TripId
        {
            get { return tripId; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("The TripId must be greater than or equal to 0");
                }
                else
                {
                    tripId = value;
                }
                }
        }

        public string DepartureCity
        {
            get { return departureCity; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The DepartureCity cannot be null or empty");
                }
                else
                {
                    departureCity = value;
                }
            }
        }

        public string ArrivalCity
        {
            get { return arrivalCity; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The ArrivalCity cannot be null or empty");
                }
                else
                {
                    arrivalCity = value;
                }
            }
        }

        public int SpotNumber
        {
            get { return spotNumber; }
            set {
                if (value < 0 && value > 4)
                {
                    throw new ArgumentException("The spotNumber must be between 1 and 4");
                }
                else
                {
                    spotNumber = value;
                }
            }
        }

        public decimal Price
        {
            get { return price; }
            set {

                if (value < 0)
                {
                    throw new ArgumentException("The id must be greater than or equal to 0");
                }
                else
                {
                    price = value;
                }
                               
            }
        }

    }


}

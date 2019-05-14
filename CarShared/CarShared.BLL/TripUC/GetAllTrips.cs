using CarShared.BLL.Domain;
using CarShared.Common.ConvertBTODTO;
using CarShared.DAL;
using CarShared.Shared.BTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.BLL.TripUC
{
    public partial class TripServices
    {
        
        public List<TripBTO> GetAllTrips()
        {
            List<TripBTO> listTrips;
            listTrips = repo.GetAll().Select(x => x.TripDTOTOTripBTO()).ToList();

            foreach (var item in listTrips)
            {
                try
                {
                    //add date to article domain
                    TripDomain tripDom = new TripDomain(item.tripId, item.departureCity, item.arrivalCity, item.NumberOfSpots, item.price);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return listTrips;

        }
    }
}

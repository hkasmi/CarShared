using CarShared.Common.converters;
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
            return tripRepo.GetAll().Select(x => x.TripDTOTOTripBTO()).ToList();

        }
    }
}

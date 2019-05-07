using CarShared.Common.converters;
using CarShared.Common.DTO;
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
        public void AddTrip(TripBTO bto)
        {
            tripRepo.Insert(bto.TripBTOTOTripDTO());

        }


    }
}

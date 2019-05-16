using CarShared.Shared.BTO;
using CarShared.Shared.ConvertBTODTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.BLL.CityUC
{
  
        public partial class CityServices
        {
            //public void AddTrip(TripBTO bto)
            //{
            //    repo.Insert(bto.TripBTOTOTripDTO());
            //    repo.Save();
            //}
            public void UpdateCity(CityBTO bto)
            {
                repo.Update(bto.CityBTOTOCityDTO());
                repo.Save();
            }

        }
    
}

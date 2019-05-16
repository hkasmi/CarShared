using CarShared.BLL.Domain;
using CarShared.Common.Enums;
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


        public List<CityBTO> GetCitiesByCountry(Country country)
        {
            List<CityBTO> listCities;
            listCities = repo.GetCitiesByCountry(country).Select(x => x.CityDTOTOCityBTO()).ToList();

            foreach (var item in listCities)
            {
                try
                {
                    //add date to article domain
                    CityDomain tripDom = new CityDomain(item.CityId, item.Name);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return listCities;
        }
    }
}

using CarShared.BLL.Domain;
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


        public CityBTO GetCityById(int id)
        {
            CityBTO city;
            city = repo.GetCityById(id).CityDTOTOCityBTO();

            
            
                try
                {
                    //add date to article domain
                    CityDomain cityDom = new CityDomain(city.CityId, city.Name);
                }
                catch (Exception e)
                {
                    throw e;
                }
            
            return city;
        }
    }
}

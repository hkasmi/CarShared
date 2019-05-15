using CarShared.DAL.Entities;
using CarShared.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.DAL.ConvertEntityToBTO
{
    public static class CityConverter
    {
        public static City CityDTOTOCity(this CityDTO dto)
        {
            return new City
            {
                CityId = dto.CityId,
                Country = dto.Country,
                Name = dto.Name

            };
        }

        public static CityDTO CityTOCityDTO(this City city)
        {
            return new CityDTO
            {
                CityId = city.CityId,
                Country = city.Country,
                Name = city.Name

            };
        }
    }
}

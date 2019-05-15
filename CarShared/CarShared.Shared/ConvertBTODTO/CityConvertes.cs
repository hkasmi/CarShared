using CarShared.Shared.BTO;
using CarShared.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.Shared.ConvertBTODTO
{
    public static class CityConvertes
    {
        public static CityDTO CityBTOTOCityDTO(this CityBTO bto)
        {
            return new CityDTO
            {
                CityId = bto.CityId,
                Country = bto.Country,
                Name = bto.Name
            };
        }

        public static CityBTO CityDTOTOCityBTO(this CityDTO dto)
        {
            return new CityBTO
            {
                CityId = dto.CityId,
                Country = dto.Country,
                Name = dto.Name

            };
        }
    }
}

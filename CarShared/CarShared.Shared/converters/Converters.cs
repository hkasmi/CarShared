using CarShared.Common.DTO;
using CarShared.Shared.BTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.Common.converters
{
    public static class Converters
    {
        public static TripDTO TripBTOTOTripDTO(this TripBTO bto)
        {
            return new TripDTO
            {
                IdTrip = bto.IdTrip,
                arrivalCity = bto.arrivalCity,
                departureCity = bto.departureCity,
                time = bto.time,
                spotNumber = bto.spotNumber,
                price = bto.price,
                description = bto.description

            };
        }

        public static TripBTO TripDTOTOTripBTO(this TripDTO dto)
        {
            return new TripBTO
            {
                IdTrip = dto.IdTrip,
                arrivalCity = dto.arrivalCity,
                departureCity = dto.departureCity,
                time = dto.time,
                price = dto.price,
                spotNumber = dto.spotNumber,
                description = dto.description

            };
        }
    }
}

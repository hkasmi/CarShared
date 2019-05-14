using CarShared.Common.DTO;
using CarShared.Shared.BTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.Common.ConvertBTODTO
{
    public static class TripConverters
    {
        public static TripDTO TripBTOTOTripDTO(this TripBTO bto)
        {
            return new TripDTO
            {
                tripId = bto.tripId,
                arrivalCity = bto.arrivalCity,
                departureCity = bto.departureCity,
                tripDate = bto.TripDate,
                NumberOfSpots = bto.NumberOfSpots,
                price = bto.price,
                description = bto.description

            };
        }

        public static TripBTO TripDTOTOTripBTO(this TripDTO dto)
        {
            return new TripBTO
            {
                tripId = dto.tripId,
                arrivalCity = dto.arrivalCity,
                departureCity = dto.departureCity,
                TripDate = dto.tripDate,
                price = dto.price,

                NumberOfSpots = dto.NumberOfSpots,
                description = dto.description

            };
        }
    }
}

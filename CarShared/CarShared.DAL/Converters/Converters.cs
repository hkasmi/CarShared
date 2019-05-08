using CarShared.Common.DTO;
using CarShared.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.DAL.Converters
{
    public static class Converters
    {
        public static Trip TripDTOTOTrip(this TripDTO dto)
        {
            return new Trip
            {
                TripId = dto.IdTrip,
                ArrivalCity = dto.arrivalCity,
                DepartureCity = dto.departureCity,
                Time = dto.time,
                SpotNumber = dto.spotNumber,
                Price = dto.price,
                Description = dto.description

            };
        }

        public static TripDTO TripTOTripDTO(this Trip trip)
        {
            return new TripDTO
            {
                IdTrip = trip.TripId,
                arrivalCity = trip.ArrivalCity,
                departureCity = trip.DepartureCity,
                time = trip.Time,
                price = trip.Price,
                spotNumber = trip.SpotNumber,
                description = trip.Description

            };
        }
    }
}

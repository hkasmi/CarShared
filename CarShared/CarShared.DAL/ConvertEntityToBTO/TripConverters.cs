using CarShared.Common.DTO;
using CarShared.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.DAL.ConvertEntityToBTO
{
    public static class TripConverters
    {
        public static Trip TripDTOTOTrip(this TripDTO dto)
        {
            return new Trip
            {
                TripId = dto.tripId,
                ArrivalCity = dto.arrivalCity,
                DepartureCity = dto.departureCity,
                TripDate = dto.tripDate,
                NumberOfSpots = dto.NumberOfSpots,
                Price = dto.price,
                Description = dto.description

            };
        }

        public static TripDTO TripTOTripDTO(this Trip trip)
        {
            return new TripDTO
            {
                tripId = trip.TripId,
                arrivalCity = trip.ArrivalCity,
                departureCity = trip.DepartureCity,
                tripDate = trip.TripDate,
                price = trip.Price,
                NumberOfSpots = trip.NumberOfSpots,
                description = trip.Description

            };
        }
    }
}

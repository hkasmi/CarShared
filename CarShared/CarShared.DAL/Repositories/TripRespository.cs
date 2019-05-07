﻿using CarShared.Common.DTO;
using CarShared.Common.Interfaces;
using CarShared.DAL.Converters;
using CarShared.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.DAL.Repositories
{
    public class TripRespository : IRepository<TripDTO>
    {
        private List<Trip> dbTrips;

        public TripRespository()
        {
            if (dbTrips == null)
            {
                InitializedbTrips();
            }
        }

        private void InitializedbTrips()
        {
            dbTrips = new List<Trip>
            { new Trip
            {
                ArrivalCity="Bruxelles",
                DepartureCity="Paris",
                Time=new DateTime(2019,12,24,10,50,00),
                Price=10,
                SpotNumber=2,
                Description="rendez vous en face à la sortie de la gare"
            },

            new Trip
            {
                ArrivalCity="Bruxelles",
                DepartureCity="Paris",
                Time=new DateTime(2019,08,12,12,30,00),
                Price=10,
                SpotNumber=2,
                Description="rendez vous en face à la sortie de la gare"
            },

            new Trip
            {
                ArrivalCity="Bruxelles",
                DepartureCity="Paris",
                Time=new DateTime(2020,01,06,10,50,00),
                Price=10,
                SpotNumber=2,
                Description="rendez vous en face à la sortie de la gare"
            },

            new Trip
            {
                ArrivalCity="Bruxelles",
                DepartureCity="Paris",
                Time=new DateTime(2019,10,02,15,20,00),
                Price=10,
                SpotNumber=2,
                Description="rendez vous en face à la sortie de la gare"
            }

            };
        }

        public List<TripDTO> GetAll()
        {
            List<TripDTO> tripDto = new List<TripDTO>();

            foreach (var item in dbTrips.ToList())
            {
                tripDto.Add(item.TripTOTripDTO());
            }
            return tripDto;
        }

        public void Insert(TripDTO entity)
        {
            dbTrips.Add(entity.TripDTOTOTrip());
        }

        public void Update(TripDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TripDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        IQueryable<TripDTO> IRepository<TripDTO>.GetAll()
        {
            throw new NotImplementedException();
        }

        public TripDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

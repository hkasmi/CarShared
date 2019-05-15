using CarShared.Common.Interfaces;
using CarShared.DAL.ConvertEntityToBTO;
using CarShared.DAL.Entities;
using CarShared.Shared.BTO;
using CarShared.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.DAL.Repositories
{
    public class CityRepository : IRepository<CityDTO>
    {
        private ApplicationDbContext CarSharedDB;

        public CityRepository(ApplicationDbContext dbContext)
        {
            CarSharedDB = dbContext;
        }

        public void Add(CityDTO entity)
        {
            CarSharedDB.Cities.Add(entity.CityDTOTOCity());
        }

        public void Delete(CityDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<CityDTO> GetAll()
        {
            List<CityDTO> cityDTO = new List<CityDTO>();

            foreach (var item in CarSharedDB.Cities.ToList())
            {
                cityDTO.Add(item.CityTOCityDTO());
            }
            return cityDTO;
        }

        public CityDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            CarSharedDB.SaveChanges();
        }

        public void Update(CityDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}

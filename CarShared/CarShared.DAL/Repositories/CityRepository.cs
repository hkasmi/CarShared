using CarShared.Common.Enums;
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
        public List<CityDTO> GetCitiesByCountry(Country country)
        {
            List<CityDTO> cityDTO = new List<CityDTO>();
            foreach (var item in CarSharedDB.Cities.ToList().Where(u => u.Country == country))
            {
                cityDTO.Add(item.CityTOCityDTO());
            }
            return cityDTO;
        }
        public CityDTO GetCityById(int id)
        {
            //return DbProduct.product.Include(x => x.Category).FirstOrDefault(u => u.Id == id).ProductToProductDTO();
            return CarSharedDB.Cities.FirstOrDefault(u => u.CityId == id).CityTOCityDTO();
        }
        public CityDTO GetById(Country country)
        {
            //return DbProduct.product.Include(x => x.Category).FirstOrDefault(u => u.Id == id).ProductToProductDTO();
            return CarSharedDB.Cities.FirstOrDefault(u => u.Country == country).CityTOCityDTO();
        }

        public void Save()
        {
            CarSharedDB.SaveChanges();
        }

        public void Update(CityDTO entity)
        {
            City cityUpd = CarSharedDB.Cities.FirstOrDefault(u => u.CityId == entity.CityId);
            cityUpd.Name = entity.Name;


            //CityDTO product = CarSharedDB.Cities.FirstOrDefault(u => u.CityId == entity.CityId).CityTOCityDTO();
            //product.Name = entity.Name;
        }

        public CityDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using CarShared.DAL;
using CarShared.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.BLL.CityUC
{
    public partial class CityServices
    {
        ApplicationDbContext db;
        CityRepository repo;
        public CityServices()
        {
            db = new ApplicationDbContext();
            repo = new CityRepository(db);
        }
    }
}

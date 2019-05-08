using CarShared.Common.DTO;
using CarShared.Common.Interfaces;
using CarShared.DAL;
using CarShared.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.BLL.TripUC
{
    public partial class TripServices
    {
        ApplicationDbContext db;
        TripRespository repo;
        public TripServices()
        {
            db = new ApplicationDbContext();
            repo = new TripRespository(db);
        }
    }
}

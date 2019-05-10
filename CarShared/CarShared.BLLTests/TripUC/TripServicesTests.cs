using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarShared.BLL.TripUC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShared.DAL.Repositories;

namespace CarShared.BLL.TripUC.Tests
{
    [TestClass()]
    public class TripServicesTests
    {
        [TestMethod()]
        public void AddTripTest()
        {
            var Tripservice = new TripServices();

            var count = Tripservice.GetAllTrips().Count;

            Tripservice.AddTrip(new Shared.BTO.TripBTO { arrivalCity = "bxl", departureCity = "paris",TripDate= DateTime.Now, NumberOfSpots=2, price =10 ,description="Testttttttt" });

            var count2 = Tripservice.GetAllTrips().Count;

            Assert.AreEqual(count + 1, count2);
        }

        [TestMethod()]
        public void GetAllTripsTest()
        {
            var Tripservice = new TripServices();

            var count = Tripservice.GetAllTrips().Count;


            Assert.AreEqual(count,9);
        }
    }
}
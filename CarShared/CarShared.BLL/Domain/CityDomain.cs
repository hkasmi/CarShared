using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.BLL.Domain
{
    class CityDomain
    {
        private int cityId;
        private string name;

        public CityDomain(int cityId, string name)
        {
            this.cityId = cityId;
            this.name = name;
        }
        public int CityId
        {
            get { return cityId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The TripId must be greater than or equal to 0");
                }
                else
                {
                    cityId = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The DepartureCity cannot be null or empty");
                }
                else
                {
                    name = value;
                }
            }
        }
    }
}

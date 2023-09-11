using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class ApartmentBuilding
    {
        /// <summary>
        /// Apartment building name help us recognize this apartment building from other buildings
        /// </summary>
        public string nameApartment { get; private set; }
        /// <summary>
        /// Apartment building has a lot of flats to possible buy it
        /// </summary>
        public List<IFlat> flats { get; set; }
        public ApartmentBuilding(string nameApartment, params Flat[] flats)
        {
            this.nameApartment = nameApartment;
            this.flats = new List<IFlat>(flats);
        }


    }
}

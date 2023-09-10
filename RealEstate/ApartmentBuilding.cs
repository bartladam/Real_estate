using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class ApartmentBuilding
    {
        public string nameApartment { get; private set; }
        public List<Flat> flats { get; set; }
        public ApartmentBuilding(string nameApartment, params Flat[] flats)
        {
            this.nameApartment = nameApartment;
            this.flats = new List<Flat>(flats);
        }


    }
}

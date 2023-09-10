using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class System
    {
        public List<ApartmentBuilding> ApartmentBuildings { get; set; }
        public List<Invoice> Invoices { get; set; }
        Administrator Administrator;
        public System()
        {
            this.ApartmentBuildings = new List<ApartmentBuilding>();
            this.Invoices = new List<Invoice>();
        }
        public string FlatOffer(int order)
        {

        }
        public Flat SelectedFlat(string indicationFlat)
        {

        }
        public void AvailabilityFlat()
        {

        }
    }
}

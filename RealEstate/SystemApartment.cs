using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class SystemApartment
    {
        public ApartmentBuilding ApartmentBuildings { get; set; }
        public List<Invoice> Invoices { get; set; }
        Administrator Administrator;
        public SystemApartment(ApartmentBuilding apartmentBuildings)
        {
            this.ApartmentBuildings = apartmentBuildings;
            this.Invoices = new List<Invoice>();
        }
        public string FlatOffer(int orders)
        {
            string resultOrder = "";
            switch(orders)
            {
                case 1:
                    var orderSize = from i in ApartmentBuildings.flats
                                where (i.sizeFlat > 40)
                                select i;
                    foreach (var item in orderSize)
                    {
                        resultOrder += string.Format("Indication flat: {0} | avaible: {1}\nsize flat: {2} m2 | floor flat: {3}\nprice flat: {4}\n\n", item.indicationFlat, item.avaible, item.sizeFlat, item.floorFlat, item.priceFlat);
                    }

                    break;
                case 2:
                    var orderPrice = from i in ApartmentBuildings.flats
                                     orderby i.priceFlat 
                                     select i;
                    foreach (var item in orderPrice)
                    {
                        resultOrder += string.Format("Indication flat: {0} | avaible: {1}\nsize flat: {2} m2 | floor flat: {3}\nprice flat: {4}\n\n", item.indicationFlat, item.avaible, item.sizeFlat, item.floorFlat, item.priceFlat);
                    }
                    break;
                case 3:
                    var orderAvaibility = from i in ApartmentBuildings.flats
                                     where (i.avaible.Equals(true))
                                     select i;
                    foreach (var item in orderAvaibility)
                    {
                        resultOrder += string.Format("Indication flat: {0} | avaible: {1}\nsize flat: {2} m2 | floor flat: {3}\nprice flat: {4}\n\n", item.indicationFlat, item.avaible, item.sizeFlat, item.floorFlat, item.priceFlat);
                    }
                    break;     
            }
            return resultOrder;

        }
        public Flat SelectedFlat(string indicationFlat)
        {
            foreach (Flat item in ApartmentBuildings.flats)
            {
                if (item.indicationFlat.Equals(indicationFlat) && item.avaible.Equals(true))
                    return item;
            }
            return null;
        }
        public void AvailabilityFlat()
        {
            foreach (Invoice invoice in Invoices)
            {
                foreach (Flat flats in ApartmentBuildings.flats)
                {
                    if (invoice.indicationFlat.Equals(flats.indicationFlat))
                        flats.BuyFlat();
                }
            }
        }
    }
}

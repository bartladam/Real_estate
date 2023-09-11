using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class SystemApartment
    {
        /// <summary>
        /// System manages apartment bulding
        /// </summary>
        public ApartmentBuilding ApartmentBuildings { get; set; }
        /// <summary>
        /// System have to know about all transaction on flats
        /// </summary>
        public List<Invoice> Invoices { get; set; }
        /// <summary>
        /// Each system should have a some Administrator
        /// </summary>
        Administrator Administrator;
        public SystemApartment(ApartmentBuilding apartmentBuildings)
        {
            this.ApartmentBuildings = apartmentBuildings;
            this.Invoices = new List<Invoice>();
        }
        /// <summary>
        /// It shows buyers sorted flats
        /// </summary>
        /// <param name="sort"></param>
        /// <returns></returns>
        public string FlatOffer(int sort)
        {
            string resultSort = "";
            switch(sort)
            {
                case 1:
                    var orderSize = from i in ApartmentBuildings.flats
                                where (i.sizeFlat > 40)
                                select i;
                    foreach (var item in orderSize)
                    {
                        resultSort += string.Format("Indication flat: {0} | avaible: {1}\nsize flat: {2} m2 | floor flat: {3}\nprice flat: {4}\n\n", item.indicationFlat, item.available, item.sizeFlat, item.floorFlat, item.priceFlat);
                    }

                    break;
                case 2:
                    var orderPrice = from i in ApartmentBuildings.flats
                                     orderby i.priceFlat 
                                     select i;
                    foreach (var item in orderPrice)
                    {
                        resultSort += string.Format("Indication flat: {0} | avaible: {1}\nsize flat: {2} m2 | floor flat: {3}\nprice flat: {4}\n\n", item.indicationFlat, item.available, item.sizeFlat, item.floorFlat, item.priceFlat);
                    }
                    break;
                case 3:
                    var orderAvaibility = from i in ApartmentBuildings.flats
                                     where (i.available.Equals(true))
                                     select i;
                    foreach (var item in orderAvaibility)
                    {
                        resultSort += string.Format("Indication flat: {0} | avaible: {1}\nsize flat: {2} m2 | floor flat: {3}\nprice flat: {4}\n\n", item.indicationFlat, item.available, item.sizeFlat, item.floorFlat, item.priceFlat);
                    }
                    break;     
            }
            return resultSort;

        }
        /// <summary>
        /// When buyer want some flat, system find this flat in database 
        /// </summary>
        /// <param name="indicationFlat"></param>
        /// <returns></returns>
        public Flat SelectedFlat(string indicationFlat)
        {
            foreach (Flat item in ApartmentBuildings.flats)
            {
                if (item.indicationFlat.Equals(indicationFlat) && item.available.Equals(true))
                    return item;
            }
            return null;
        }
        /// <summary>
        /// If someone buy the flat, so system change availability flat
        /// </summary>
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

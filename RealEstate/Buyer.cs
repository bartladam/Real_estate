using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Buyer
    {
        /// <summary>
        /// Buyer name is important for invoice
        /// </summary>
        private string nameBuyer { get; set; }
        /// <summary>
        /// Buyer surname is important for invoice
        /// </summary>
        private string surnameBuyer { get; set; }
        /// <summary>
        /// Buyer communication with system about business transaction
        /// </summary>
        private SystemApartment system { get; set; }
        public Buyer(string nameBuyer, string surnameBuyer, SystemApartment system)
        {
            this.nameBuyer = nameBuyer;
            this.surnameBuyer = surnameBuyer;
            this.system = system;
        }
        /// <summary>
        /// Buyer have chosen flat and now he have to make transaction to buy it
        /// </summary>
        /// <param name="flat"></param>
        private void BuyFlat(Flat flat)
        {
            Invoice invoice = new Invoice(nameBuyer, surnameBuyer, flat.sizeFlat, flat.floorFlat, true, flat.indicationFlat, flat.priceFlat);
            system.Invoices.Add(invoice);
            system.AvailabilityFlat();
        }
        /// <summary>
        /// Buyer can sort his offer flats
        /// </summary>
        /// <param name="sort"></param>
        private void FlatOffer(int? sort)
        {
            if(sort is null || sort > 2)
            {
                Console.WriteLine("Flats sorted by their price:\n");
                Console.WriteLine(system.FlatOffer(2)); 
            }
            else if(sort.Equals(1))
            {
                Console.WriteLine("Flats sorted by their size (>40 m2):\n");
                Console.WriteLine(system.FlatOffer(1));
            }
            else if (sort.Equals(2))
            {
                Console.WriteLine("Flats sorted by their avaibility:\n");
                Console.WriteLine(system.FlatOffer(3));
            }
            Console.WriteLine("-------------------");

        }
        /// <summary>
        /// This method helps buyer to orient in buying process
        /// </summary>
        public void BuyerInterface()
        {
            while (true)
            {

                Flat selectedFlat;
                uint pay;
                Console.Clear();
                Console.WriteLine("Sort flat [y/n] - if selected [n] offer is automatically sorting by price");
                string sortChoice = Console.ReadLine();
                if(sortChoice.ToLower().Equals("y"))
                {
                    Console.WriteLine(@"
1 - sort by size
2 - sort avaibility");

                    Console.Write("Select sort method: ");
                    FlatOffer(int.Parse(Console.ReadLine()));
                }
                else
                {
                    FlatOffer(null);
                }
                Console.Write("Write selected flat: ");
                string buyerSelectedFlat = Console.ReadLine();
                Console.Clear();
                if (system.SelectedFlat(buyerSelectedFlat) is not null)
                {
                    selectedFlat = system.SelectedFlat(buyerSelectedFlat);
                    Console.WriteLine("Indication flat: {0}\navaible: {1}\nsize flat: {2} m2\nfloor flat: {3}\nprice flat: {4}", selectedFlat.indicationFlat, selectedFlat.available, selectedFlat.sizeFlat, selectedFlat.floorFlat, selectedFlat.priceFlat);
                    Console.WriteLine("Do you want buy it: [y/n]");
                    string choice = Console.ReadLine();

                    if(choice.ToLower().Equals("y"))
                    {
                        Console.Write("\nPay:");
                        while (!uint.TryParse(Console.ReadLine(), out pay))
                        {
                            Console.Write("Pay:");
                        }
                        if(pay.Equals(selectedFlat.priceFlat))
                        {
                            BuyFlat(selectedFlat);
                            Console.WriteLine("You bought flat: {0}", selectedFlat.indicationFlat);
                        }  
                    }
                    else
                        Console.WriteLine("Transaction canceled.");
                }
                Console.ReadKey();
            }

        }
    }
}

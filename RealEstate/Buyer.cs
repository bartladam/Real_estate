using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Buyer
    {
        public string nameBuyer { get; private set; }
        public string surnameBuyer { get; private set; }
        public SystemApartment system { get; private set; }
        public Buyer(string nameBuyer, string surnameBuyer, SystemApartment system)
        {
            this.nameBuyer = nameBuyer;
            this.surnameBuyer = surnameBuyer;
            this.system = system;
        }
        private void BuyFlat(Flat flat)
        {
            Invoice invoice = new Invoice(nameBuyer, surnameBuyer, flat.sizeFlat, flat.floorFlat, true, flat.indicationFlat, flat.priceFlat);
            system.Invoices.Add(invoice);
            system.AvailabilityFlat();
        }
        private void FlatOffer(int? order)
        {
            if(order is null || order > 2)
            {
                Console.WriteLine("Flats ordered by their price:\n");
                Console.WriteLine(system.FlatOffer(2)); 
            }
            else if(order.Equals(1))
            {
                Console.WriteLine("Flats ordered by their size (>40 m2):\n");
                Console.WriteLine(system.FlatOffer(1));
            }
            else if (order.Equals(2))
            {
                Console.WriteLine("Flats ordered by their avaibility:\n");
                Console.WriteLine(system.FlatOffer(3));
            }
            Console.WriteLine("-------------------");

        }
        public void BuyerInterface()
        {
            while (true)
            {

                Flat selectedFlat;
                uint pay;
                Console.Clear();
                Console.WriteLine("Order flat [y/n]");
                string orderChoice = Console.ReadLine();
                if(orderChoice.ToLower().Equals("y"))
                {
                    Console.WriteLine(@"
1 - order by size
2 - order avaibility");

                    Console.Write("Select order method: ");
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
                    Console.WriteLine("Indication flat: {0}\navaible: {1}\nsize flat: {2} m2\nfloor flat: {3}\nprice flat: {4}", selectedFlat.indicationFlat, selectedFlat.avaible, selectedFlat.sizeFlat, selectedFlat.floorFlat, selectedFlat.priceFlat);
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

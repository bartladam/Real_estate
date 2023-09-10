using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Invoice
    {
        private string nameBuyer { get;  set; }
        private string surnameBuyer { get; set; }
        private DateTime dayOfPurchase { get; set; }
        private int sizeFlat { get; set; }
        private int floorFlat { get; set; }
        private bool paid { get; set; }
        private string indicationFlat { get; set; }
        private uint priceFlat { get; set; }
        public Invoice(string nameBuyer, string surnameBuyer, int sizeFlat, int floorFlat, bool paid, string indicationFlat, uint priceFlat)
        {
            dayOfPurchase = DateTime.Now;
            this.nameBuyer = nameBuyer;
            this.surnameBuyer = surnameBuyer;
            this.sizeFlat = sizeFlat;
            this.floorFlat = floorFlat;
            this.paid = paid;
            this.indicationFlat = indicationFlat;
            this.priceFlat = priceFlat;
        }
        private void SendToSystem(System system)
        {
            
        }
    }
}

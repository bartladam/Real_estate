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
        /// <summary>
        /// Each invoice have to be addressed to some name
        /// </summary>
        private string nameBuyer { get;  set; }
        /// <summary>
        /// Each invoice have to be addressed to some surname
        /// </summary>
        private string surnameBuyer { get; set; }
        /// <summary>
        /// Day of purchase is important for complaint and protect customer
        /// </summary>
        private DateTime dayOfPurchase { get; set; }
        /// <summary>
        /// Information about flat, what buyer bought
        /// </summary>
        private int sizeFlat { get; set; }
        /// <summary>
        /// Buyer have to be orient, on which floor he bought flat
        /// </summary>
        private int floorFlat { get; set; }
        /// <summary>
        /// Check buyer transaction
        /// </summary>
        private bool paid { get; set; }
        /// <summary>
        /// Indication flat is important for change availability when flat is bought
        /// </summary>
        public string indicationFlat { get; private set; }
        /// <summary>
        /// The buyer must know about price his flat
        /// </summary>
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

    }
}

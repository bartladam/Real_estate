using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Flat:IFlat
    {
        /// <summary>
        /// Shows buyer if flat available
        /// </summary>
        public bool available { get; private set; } = true;
        /// <summary>
        /// For which price is flat available
        /// </summary>
        public uint priceFlat { get; private set; }
        /// <summary>
        /// That's information buyer what size flat he can buy
        /// </summary>
        public int sizeFlat { get; private set; }
        /// <summary>
        /// If flat is on higher floor his price is bigger. 
        /// We use too for information buyer about position flat
        /// </summary>
        public int floorFlat { get; private set; }
        /// <summary>
        /// Indication flat helps system and buyer to know about flat and his availability
        /// </summary>
        public string indicationFlat { get; private set; }
        public Flat(uint priceFlat, int sizeFlat, int floorFlat, string indicationFlat)
        {
            this.priceFlat = priceFlat;
            this.sizeFlat = sizeFlat;
            this.floorFlat = floorFlat;
            this.indicationFlat = indicationFlat;
        }
        /// <summary>
        /// Buying flat changes availability this flat and the next buyer can not buy this flat
        /// </summary>
        public void BuyFlat()
        {
            available = false;
        }
    }
}

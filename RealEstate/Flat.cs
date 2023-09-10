using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Flat
    {
        public bool avaible { get; private set; } = true;
        public uint priceFlat { get; private set; }
        public int sizeFlat { get; private set; }
        public int floorFlat { get; private set; }
        public string indicationFlat { get; private set; }
        public Flat(uint priceFlat, int sizeFlat, int floorFlat, string indicationFlat)
        {
            this.priceFlat = priceFlat;
            this.sizeFlat = sizeFlat;
            this.floorFlat = floorFlat;
            this.indicationFlat = indicationFlat;
        }
        public void BuyFlat()
        {
            avaible = false;
        }
    }
}

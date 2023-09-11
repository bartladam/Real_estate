using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal interface IFlat
    {
        bool available { get; }
        uint priceFlat { get; }
        int sizeFlat { get; }
        int floorFlat { get; }
        string indicationFlat { get; }
        void BuyFlat();

    }
}

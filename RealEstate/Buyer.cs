﻿using System;
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
        public Buyer(string nameBuyer, string surnameBuyer)
        {
            this.nameBuyer = nameBuyer;
            this.surnameBuyer = surnameBuyer;
        }
        public void BuyFlat(Flat flat)
        {

        }
        public void FlatOffer(System system)
        {

        }
        public void BuyerInterface(System system)
        {

        }
    }
}

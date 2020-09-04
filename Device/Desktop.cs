using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop
{
    public class Desktop : Device //Create a “Desktop” class derived from “Device” with the following:
    {
        //Added override of brand
        public override string Brand { get; set; }

        //A default and greedy constructor.
        public Desktop(string brand)
        {
            Brand = brand;
        }
    }
}

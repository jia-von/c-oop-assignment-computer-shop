using System;
using System.Collections.Generic;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    public class Cellphone : Device //Create a “CellPhone” class derived from “Device” with the following:
    {
        public Screen Screen { get; set; } //TODO: A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.

        //A default and greedy constructor.
        public Cellphone(string brand)
        {
            Brand = brand;
        }
    }
}

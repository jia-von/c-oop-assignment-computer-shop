using System;
using System.Collections.Generic;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    public class Laptop : Device //Create a “Laptop” class derived from “Device” with the following:
    {
        //A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.
        public Screen Screen { get; set; }

        //A “Keyboard” property that must have a “Keyboard” object with the “Integrated” connector type assigned.
        public Keyboard Keyboard { get; set; }

        //Overrride accoding to the class example
        public override string Brand { get; set; }

        //A default and greedy constructor.
        public Laptop(Screen screen, Keyboard keyboard, string brand)
        {
            Screen = screen;
            Keyboard = keyboard;
            Brand = brand;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop
{
    /*
        A “Connectors” property (a read-only dictionary keyed with values of the Connector enumeration and valued with ints to represent the number of connections available)
        A “Peripherals” property (a polymorphic list of Peripheral objects)
     */

    //Create an abstract “Device” class with the following:
    public abstract class Device
    {
        //A “Brand” property default public abstract
        public abstract string Brand { get; set; } 

        //A “CPU” property (reference to “CPU” object) -- Default public get/set
        public CPU CPU { get; set; }

        //A “Memory” property (a list of “Memory” objects) --Default public get.set
        public Memory Memory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    //Create an abstract “Device” class with the following:
    public abstract class Device
    {
        //A “Brand” property default public abstract
        public abstract string Brand { get; set; } 

        //A “CPU” property (reference to “CPU” object) -- Default public get/set
        public CPU CPU { get; set; }

        //A “Memory” property (a list of “Memory” objects) --Default public get.set
        public Memory Memory { get; set; }

        // A “Connectors” property (a read-only dictionary keyed with values of the Connector enumeration and valued with ints to represent the number of connections available)
        public ReadOnlyDictionary<Peripheral.Peripheral.Connector, int> Connectors { get; set; }

        //A “Peripherals” property (a polymorphic list of Peripheral objects) private
        private List<Peripheral.Peripheral> Peripherals { get; set; }

        /*
            A “ConnectPeripheral()” method that accepts a polymorphic peripheral argument and:
            Throws an exception if there are no available connectors of the connection-type of the peripheral.
            Unless the type is “Integrated”.
            Otherwise, adds the peripheral to the list.

         */

        public void ConnectedPeripheral(Peripheral.Peripheral peripheral)
        {
            Console.WriteLine(peripheral);
        }
    }
}

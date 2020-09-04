using System;
using System.Collections.Generic;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    /*
        A “Connectors” property (a read-only dictionary keyed with values of the Connector enumeration and valued with ints to represent the number of connections available)

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

        //public ReadOnlyMemory<Connector>

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
            try
            {
                if (peripheral != ConnectorType.Connector.Integrated)
                {
                    Peripherals.Add(peripheral);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("There are no available connectors of the connection-type of the peripheral");
            }
        }
    }
}

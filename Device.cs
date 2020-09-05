using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    //Create an abstract “Device” class with the following:
    public abstract class Device
    {
        //A “Brand” property (string).
        public string Brand { get; set; }

        //A “Speed” property (double).
        public double Speed { get; set; }

        //A “CPU” property (reference to “CPU” object) -- Default public get/set
        public CPU CPU { get; set; }

        //A “MemoryBank” property (a list of “Memory” objects)
        public List<Memory> MemoryBank { get; set; }

        /*
         A “Connectors” property as a read-only dictionary. 
            The keys will come from the Connector enumeration (enum = enumeration).
             The values will be ints to represent the number of connections available.
         */
        public ReadOnlyDictionary<Connector, int> Connectors { get; set; }

        //A “Peripherals” property (a polymorphic list of Peripheral objects) private
        private List<Peripheral.Peripheral> Peripherals { get; set; }

        public Device()// default constructor
        {
            Brand = "Default Device";
            Speed = 0;
            CPU = new CPU();
            MemoryBank = new List<Memory>();
            Peripherals = new List<Peripheral.Peripheral>();
        }

        /*

    Throws an exception if there are no available connectors of the connection-type of the peripheral.
    Unless the type is “Integrated”.
    Otherwise, adds the peripheral to the list.

 */
        //A “ConnectPeripheral()” method that accepts a polymorphic peripheral argument and:
        /*
         Throws an exception if there are no available connectors of the connection-type of the peripheral.
                Unless the type is “Integrated”.
        Otherwise, adds the peripheral to the list.
         */
        public void ConnectedPeripheral(Peripheral.Peripheral peripheral)//accepting objects of either keyboard, mouse, or screen
        {
            try
            {
                    Peripherals.Add(peripheral);
            }
            catch (Exception)
            {       
                    throw new Exception();
            }
        }

        /*
         A “DisconnectPeripheral()” method that accepts a type of peripheral, and will disconnect all connected peripherals of that type.
         */
        public void DisconnectedPeripheral(Peripheral.Peripheral peripheral)
        {
            Console.WriteLine(peripheral);
        }

        /*
         An abstract “StartUp()” method that will be overridden in each derived class, with some functionality of your choice. Write something to the console, make the computer beep, whatever you’d like.
         */

        public abstract void StartUp();
    }
}

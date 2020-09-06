using System;
using Computer_Shop.Peripheral;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Computer_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            Cellphone newCell = new Cellphone()
            {
                Brand = "iPhone 11",
                Speed = 2.66,
                CPU = new CPU() { Brand = "Apple A13 Bionic" },
                Screen = new Screen(828, 1729, Connector.Integrated, "LG Display Co."),
                MemoryBank = new List<Memory>(),
                Ports = new Dictionary<Connector, int>() //One for microUsb charging port
            };

            ////Add memory for iPhone in RAM and standard phone only have 1 port
            newCell.MemoryBank.Add(new Memory() { Brand = "Apple", Size = 4 });
            newCell.Ports.Add(Connector.MicroUSB, 1);

            //Test the methods
            newCell.ConnectedPeripheral(new Screen());
            newCell.DisconnectedPeripheral(new Screen());
            newCell.StartUp();


        }
    }
}

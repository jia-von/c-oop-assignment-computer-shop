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
                Connectors = new ReadOnlyDictionary<Connector, int>(new Dictionary<Connector, int>() { {Connector.MicroUSB, 1} })
        };

            ////Add memory for iPhone in RAM and standard phone only have 1 port
            newCell.MemoryBank.Add(new Memory() { Brand = "Apple", Size = 4 });

            //Test the methods
            newCell.StartUp(); //To startup the device

            Desktop newDesktop = new Desktop()
            {
                Brand = "Joe's Battlestation",
                Speed = 3.80,
                CPU = new CPU() { Brand = "AMD Ryzen 5 3600 X" },
                MemoryBank = new List<Memory>(),
                //Adding new Connectors to the desktop
                Connectors = new ReadOnlyDictionary<Connector, int>(new Dictionary<Connector, int>() { { Connector.DisplayPort, 2 }, { Connector.USBTypeC, 1 }, { Connector.USBTypeA, 4 }, { Connector.MicroUSB, 1 } }) 
            };

            //Add memory for the Desktop in RAM and determine how many connectors there is
            newDesktop.MemoryBank.Add(new Memory() { Brand = "Biggie Memory", Size = 16 });

            //Add Peripherals for Desktop
            newDesktop.ConnectedPeripheral(new Screen(1920, 1080, Connector.DisplayPort, "Mr. Gaming HD")); //Connected to a screen
            newDesktop.ConnectedPeripheral(new Keyboard(Keyboard.Type.Mechanical, Connector.USBTypeA, "Mr. Speedy Mech"));//Conneced to keyboard 

            // Connected to mouse however connection is not available based on the desktop made without USBTypeB
            //newDesktop.ConnectedPeripheral(new Mouse(7, Connector.USBTypeB, "4 Seven Digit Mutant")); //--> Test here by uncommenting this code

            newDesktop.ConnectedPeripheral(new Screen(1920, 1080, Connector.DisplayPort, "Walmart")); //Connected to a screen

            //Check with disconnect
            newDesktop.DisconnectedPeripheral(new Screen(1920, 1080, Connector.DisplayPort, "Mr. Gaming HD")); //Remove based on brand type
            newDesktop.StartUp(); //To startup the device


            Laptop newLaptop = new Laptop()
            {
                Brand = "ASUS",
                Speed = 1.60,
                CPU = new CPU() { Brand = "Intel(R)" },
                MemoryBank = new List<Memory>(),
                Screen = new Screen(1920, 1080, Connector.Integrated, "Generic PnP Monitor"),
                Keyboard = new Keyboard(Keyboard.Type.Membrane, Connector.Integrated, "Standard"),
                Connectors = new ReadOnlyDictionary<Connector, int>(new Dictionary<Connector, int>() { { Connector.USBTypeA, 2 }, { Connector.DisplayPort, 1 } })
        };

        }
    }
}

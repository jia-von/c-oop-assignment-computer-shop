using System;
using Computer_Shop.Peripheral;

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
                Screen = new Screen(828, 1729, Connector.Integrated, "LG Display Co.")
            };

            Desktop newDesktop = new Desktop()
            {
                Brand = "Joe's Battlestation",
                Speed = 3.80,
                CPU = new CPU() { Brand = "AMD Ryzen 5 3600 X" }
            };

            Laptop newLaptop = new Laptop()
            {
                Brand = "ASUS",
                Speed = 1.60,
                CPU = new CPU() { Brand = "Intel(R)" },
                Screen = new Screen(1920, 1080, Connector.Integrated, "Generic PnP Monitor"),
                Keyboard = new Keyboard(Keyboard.Type.Membrane, Connector.Integrated, "Standard")
            };

            //Desktop needs, screen, keyboard and mouse
            newDesktop.ConnectedPeripheral(new Screen(1920, 1080, Connector.DisplayPort, "Mr. Gaming HD")); //Connected to screen 
            newDesktop.ConnectedPeripheral(new Keyboard(Keyboard.Type.Mechanical, Connector.USBTypeA, "Mr. Speedy Mech"));//Conneced to keyboard 
            newDesktop.ConnectedPeripheral(new Mouse(7, Connector.USBTypeB, "4 Seven Digit Mutant"));// Connected to mouse 

            Console.WriteLine($"The {newDesktop.Brand} {newDesktop.CPU.Brand} with speed of {newDesktop.Speed}. A total of {newDesktop.Peripherals.Count} connected");

            newDesktop.DisconnectedPeripheral(new Screen(1920, 1080, Connector.DisplayPort, "Mr. Gaming HD"));

            Console.WriteLine($"The {newDesktop.Brand} {newDesktop.CPU.Brand} with speed of {newDesktop.Speed}. A total of {newDesktop.Peripherals.Count} connected");
        }
    }
}

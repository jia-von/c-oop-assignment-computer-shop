using System;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laptop(Screen screen, Keyboard keyboard, string brand)
            //Screen(int width, int height, Connector connectorType, string brand)
            //public Keyboard(Type keyType, Connector connectorType, string brand)

            /*
         public enum Connector
        {
            USBTypeA,
            USBTypeB,
            USBTypeC,
            MiniUSB,
            MicroUSB,
            DisplayPort,
            Integrated,
        }*/
            Laptop newComp = new Laptop(new Screen(1024, 600, Peripheral.Peripheral.Connector.DisplayPort, "Asus"), 
                                        new Keyboard(Keyboard.Type.Mechanical, Peripheral.Peripheral.Connector.USBTypeA, "Walmart"),
                                        "Toshiba");
            Console.WriteLine($"This laptop have screen brand {newComp.Screen.Brand}, with width {newComp.Screen.Width} and height {newComp.Screen.Height}. The connector type is {newComp.Screen.ConnectorType} \n" +
                $"The keyboard brand is {newComp.Keyboard.Brand} and the keyboard type is {newComp.Keyboard.KeyType}. The connector type is {newComp.Keyboard.ConnectorType}. \n" +
                $"The brand of the entire laptop is {newComp.Brand}");
        }
    }
}

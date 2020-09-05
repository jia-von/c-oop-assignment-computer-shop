using System;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //public Desktop(string brand)
            Cellphone newCell = new Cellphone()
            {
                Brand = "Nokia",
                Speed = 1000,
                CPU = new CPU()
            };

            newCell.ConnectedPeripheral(new Screen());
            newCell.ConnectedPeripheral(new Keyboard());

            Console.WriteLine($"The number of peripherals recorded currently is {1}");
        }
    }
}

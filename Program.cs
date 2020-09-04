using System;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //public Desktop(string brand)
            Desktop newDesktop = new Desktop("Toshiba");

            CPU newCPU = new CPU()
            {
                Brand = "Walmart",
                Speed = 1095
            };

            Console.WriteLine($"The number of peripherals recorded currently is {1}");
        }
    }
}

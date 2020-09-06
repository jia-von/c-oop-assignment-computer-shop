using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    public class Cellphone : Device //Create a “CellPhone” class derived from “Device” with the following:
    {

        public Screen Screen 
        { 
          get => new Screen() { ConnectorType = Connector.Integrated };
          set => new Screen() { ConnectorType = Connector.Integrated }; //A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.
        }

        //A default and greedy constructor.
        public Cellphone()
        {
            Brand = "Default Cellphone";
            Speed = 0;
            CPU = new CPU();
            Screen = new Screen();
            MemoryBank = new List<Memory>();

        }
        public Cellphone(string brand, double speed, CPU cpu, List<Memory> memoryBank, Dictionary<Connector, int> dictionary)
        {
            Brand = brand;
            Speed = speed;
            CPU = cpu;
            MemoryBank = memoryBank;
        }

        public override void StartUp()
        {
            Console.Beep();
            Console.WriteLine("Cellphone started up!");
        }
    }
}

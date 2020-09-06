using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    public class Desktop : Device //Create a “Desktop” class derived from “Device” with the following:

    //Create your dictionary in the constructor as a normal dictionary, then feed it into the constructor of ReadOnlyDictionary.
    {
        //A default and greedy constructor.
        public Desktop()
        {
            Brand = "Default Desktop";
            Speed = 0;
            CPU = new CPU();
            MemoryBank = new List<Memory>();
            _dictionary = new Dictionary<Connector, int>();
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary);
        }

        public Desktop(string brand, double speed, CPU cpu, List<Memory> memoryBank)
        {
            Brand = brand;
            Speed = speed;
            CPU = cpu;
            MemoryBank = memoryBank;
        }

        public override void StartUp()
        {
            Console.Beep();
            Console.WriteLine("Desktop started up!");
        }
    }

}
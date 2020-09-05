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
        private IDictionary<Connector, int> _dictionary { get; set; }
        //A default and greedy constructor.
        public Desktop()
        {
            Brand = "Default Desktop";
            Speed = 0;
            CPU = new CPU();
            MemoryBank = new List<Memory>();
            _dictionary = new Dictionary<Connector, int>();
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary); //ReadOnly must have parameters of IDictionary<TKey,TValue>
        }

        public Desktop(string brand, double speed, CPU cpu, List<Memory> memoryBank, Dictionary<Connector, int> dictionary)
        {
            Brand = brand;
            Speed = speed;
            CPU = cpu;
            MemoryBank = memoryBank;
            _dictionary = dictionary;
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary); //ReadOnly must have parameters of IDictionary<TKey,TValue>
            //@link: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2?view=netcore-3.1#properties
        }
    }

}
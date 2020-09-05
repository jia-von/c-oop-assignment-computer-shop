using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    public class Cellphone : Device //Create a “CellPhone” class derived from “Device” with the following:
    {
        public Screen Screen => new Screen() { ConnectorType = Connector.Integrated };
        //A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.

        private IDictionary<Connector, int> _dictionary  { get; set; }
    //A default and greedy constructor.

    public Cellphone()
        {
            Brand = "Default Cellphone";
            Speed = 0;
            CPU = new CPU();
            MemoryBank = new List<Memory>();
            _dictionary = new Dictionary<Connector, int>();
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary); //ReadOnly must have parameters of IDictionary<TKey,TValue>
        }
        public Cellphone(string brand, double speed, CPU cpu, List<Memory> memoryBank, Dictionary<Connector, int> dictionary)
        {
            Brand = brand;
            Speed = speed;
            CPU = cpu;
            MemoryBank = memoryBank;
            _dictionary = dictionary;
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary); //ReadOnly must have parameters of IDictionary<TKey,TValue>
        }
    }
}

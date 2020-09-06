using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Computer_Shop.Peripheral;

namespace Computer_Shop
{
    public class Laptop : Device //Create a “Laptop” class derived from “Device” with the following:
    {
        //A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.
        public Screen Screen { get; set; }

        //A “Keyboard” property that must have a “Keyboard” object with the “Integrated” connector type assigned.
        public Keyboard Keyboard { get; set; }

        //A default and greedy constructor.

        public Laptop()
        {
            Brand = "Default Desktop";
            Speed = 0;
            CPU = new CPU();
            MemoryBank = new List<Memory>();
            _dictionary = new Dictionary<Connector, int>();
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary);
            Screen = new Screen();
            Keyboard = new Keyboard();
        }
        public Laptop(string brand, double speed, CPU cpu, List<Memory> memoryBank, Screen screen, Keyboard keyboard)
        {
            Brand = brand;
            Speed = speed;
            CPU = cpu;
            MemoryBank = memoryBank;
            _dictionary = new Dictionary<Connector, int>();
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary);
            Screen = screen;
            Keyboard = keyboard;
        }
        public override void StartUp()
        {
            Console.Beep();
            Console.WriteLine("Laptop started up!");
        }
    }
}

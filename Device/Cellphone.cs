﻿using System;
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
          set => new Screen() { ConnectorType = Connector.Integrated } ; //A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.
        }

        //A default and greedy constructor.
        public Cellphone()
        {
            Brand = "Default Device";
            Speed = 0;
            CPU = new CPU();
            MemoryBank = new List<Memory>();
            _dictionary = new Dictionary<Connector, int>();
            Connectors = new ReadOnlyDictionary<Connector, int>(_dictionary);
        }
        public Cellphone(Screen screen)
        {
            Screen = screen;
        }

        public override void StartUp()
        {
            Console.Beep();
            Console.WriteLine("Cellphone started up!");
        }
    }
}

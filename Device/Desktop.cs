using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Computer_Shop
{
    public class Desktop : Device //Create a “Desktop” class derived from “Device” with the following:

    //Create your dictionary in the constructor as a normal dictionary, then feed it into the constructor of ReadOnlyDictionary.
    {
        //A default and greedy constructor.
        public Desktop()
        {
            Brand = "Default Brand";
            CPU = new CPU();
            Memory = new List<Memory>();
            var _dictionary = new Dictionary<Peripheral.Peripheral.Connector, int>() //Aaron methodology and explanation September 4, 2020, Note below
            {
                { Peripheral.Peripheral.Connector.USBTypeA, 0 },
                { Peripheral.Peripheral.Connector.USBTypeB, 1 },
                { Peripheral.Peripheral.Connector.USBTypeC, 2 },
                { Peripheral.Peripheral.Connector.MiniUSB, 3 },
                { Peripheral.Peripheral.Connector.MicroUSB, 4 },
                { Peripheral.Peripheral.Connector.DisplayPort, 5 },
                { Peripheral.Peripheral.Connector.Integrated, 6 },
            };
            Connectors = new ReadOnlyDictionary<Peripheral.Peripheral.Connector, int>(_dictionary);
        }
    }

}/*
   Upon further reading, within the parentheses of Dictionary<KeyT, ValueT>(this is the area where capacity is defined);
   Since I did not define the capcity of the new dictionary with a value, therefore the capacity is now defined based on the values added, like how array is initialized but not defined. 
  */

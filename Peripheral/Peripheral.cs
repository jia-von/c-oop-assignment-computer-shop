using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public abstract class Peripheral
    {
        //A “Brand” property (string).
        public string Brand { get; set; }

        //Create a public “Connector” enumeration of “USBTypeA”, “USBTypeB”, “USBTypeC”, “MiniUSB”, “MicroUSB”, “DisplayPort” and “Integrated”.

        public enum Connector
        {
            USBTypeA,
            USBTypeB,
            USBTypeC,
            MiniUSB,
            MicroUSB,
            DisplayPort,
            Integrated,
        }
    }
}

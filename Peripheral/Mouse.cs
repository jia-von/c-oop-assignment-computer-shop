using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public class Mouse : Peripheral //Create a “Mouse” class derived from “Peripheral” with the following:
    {
        /*
         		
		            
		            A “ConnectorType” with a value of the “Connector” enumeration.
		            A default and greedy constructor.
         */

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
        public int ButtonCount { get; set; } //A “ButtonCount” property (int).
        public int MyProperty { get; set; }
    }
}

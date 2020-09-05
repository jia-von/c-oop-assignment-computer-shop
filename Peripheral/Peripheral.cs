using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public abstract class Peripheral
    {
        //A “Brand” property (string).
        public string Brand { get; set; } //Set to only readonly following Sept 4, 2020 example, increasing security

        //A “ConnectorType” with a value of the “Connector” enumeration. Since the children of all the peripherals have the same property, I want to make it easier to just define once in the parent peripheral
        public Connector ConnectorType { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public class Mouse : Peripheral //Create a “Mouse” class derived from “Peripheral” with the following:
    {
        public int ButtonCount { get; set; } //A “ButtonCount” property (int).
        public Connector ConnectorType { get; set; } //A “ConnectorType” with a value of the “Connector” enumeration.

        public override string Brand { get; }// added for security reasons and fun!

        //A default and greedy constructor.
        public Mouse(int buttonCount, Connector connectorType, string brand)
        {
            ButtonCount = buttonCount;
            ConnectorType = connectorType;
            Brand = brand;
        }
    }
}
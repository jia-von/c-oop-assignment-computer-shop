using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public class Screen : Peripheral //Create a “Screen” class derived from “Peripheral” with the following:
    {
        public override string Brand { get; } //created for improved security and FUN! THEY SAY!

        //A “Width” property, in whole pixels (int).
        public int Width { get; set; }

        //A “Height” property, in whole pixels (int).
        public int Height { get; set; }

        //A “ConnectorType” with a value of the “Connector” enumeration.
        public Connector ConnectorType { get; set; }

        //A default and greedy constructor.
        public Screen(int width, int height, Connector connectorType, string brand)
        {
            Width = width;
            Height = height;
            ConnectorType = connectorType;
            Brand = brand;
        }
    }
}

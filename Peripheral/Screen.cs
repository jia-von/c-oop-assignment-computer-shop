using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public class Screen : Peripheral //Create a “Screen” class derived from “Peripheral” with the following:
    {
        //A “Width” property, in whole pixels (int).
        public int Width { get; set; }

        //A “Height” property, in whole pixels (int).
        public int Height { get; set; }

        //A default and greedy constructor.

        public Screen()
        {
            Width = 0;
            Height = 0;
            ConnectorType = 0;
            Brand = "Default Screen";
        }
        public Screen(int width, int height, Connector connectorType, string brand)
        {
            Width = width;
            Height = height;
            ConnectorType = connectorType;
            Brand = brand;
        }
    }
}

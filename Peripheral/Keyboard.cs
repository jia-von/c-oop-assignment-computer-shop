using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public class Keyboard : Peripheral //Create a “Keyboard” class derived from “Peripheral” with the following:
    {
        //A “Type” enumeration of: “Mechanical” or “Membrane”.
        public enum Type
        {
            Mechanical,
            Membrane
        }
        //Added my own KeyType properties because the assignment requires a greedy constructor
        public Type KeyType { get; set; }

        //A default and greedy constructor.

        public Keyboard()
        {
            KeyType = 0;
            ConnectorType = 0;
            Brand = "Default Keyboard";
        }
        public Keyboard(Type keyType, Connector connectorType, string brand)
        {
            KeyType = keyType;
            ConnectorType = connectorType;
            Brand = brand;
        }
    }
}

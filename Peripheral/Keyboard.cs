using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop.Peripheral
{
    public class Keyboard : Peripheral //Create a “Keyboard” class derived from “Peripheral” with the following:
    {
        /*
         		
		            
		            A “ConnectorType” property with a value of the “Connector” enumeration.
		            A default and greedy constructor.
         */
        //A “Type” enumeration of: “Mechanical” or “Membrane”.
        enum Type
        {
            Mechanical,
            Membrane
        }
    }
}

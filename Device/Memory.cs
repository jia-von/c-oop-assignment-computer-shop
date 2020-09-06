using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Shop
{
    public class Memory //Create a “Memory” class with the following: default class public
    {
        //A “Brand” property (string).
        public string Brand { get; set; } //default public get set

        //A “Size” property (int).
        public int Size { get; set; } //default public get/set

        public Memory ()
        {
            Brand = "Default Memory";
            Size = 16;
        }

        public Memory (string brand, int size)
        {
            Brand = brand;
            Size = size;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohitconsoleapp
{
    internal class Abstraction1
    {
        public class Laptop
        {
            private string brand;
            private string model;
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public void LaptopDetails()
            {
                Console.WriteLine("Brand: " + Brand);
                Console.WriteLine("Model: " + Model);
            }
            public void LaptopKeyboard()
            {
                Console.WriteLine("Type using Keyword");
            }
            private void MotherBoardInfo()
            {
                Console.WriteLine("MotheBoard Information");
            }
            private void InternalProcessor()
            {
                Console.WriteLine("Processor Information");
            }
        }
    }
}

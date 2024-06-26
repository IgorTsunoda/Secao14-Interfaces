﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem.Device
{
     class ComboDevice : Device, IScanner, IPrinter
    {
        public override void Print(string document)
        {
            Console.WriteLine("Combo device print: " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo device processing: " + document);
        }

        public string Scan()
        {
            return "Combo device scan result";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SolutionWithoutInterface.Service
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
            
            //amount <= 100.0 ? return (amount * 0.2) : return (amount * 0.15);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerdarVsDoContract.Model.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI*(Radius * Radius);
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

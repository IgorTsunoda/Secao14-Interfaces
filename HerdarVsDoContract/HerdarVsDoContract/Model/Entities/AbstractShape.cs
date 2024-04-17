using HerdarVsDoContract.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerdarVsDoContract.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}

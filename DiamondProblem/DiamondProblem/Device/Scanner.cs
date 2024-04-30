using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem.Device
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing " + document);
        }
        public void Scan(string document)
        {
            Console.WriteLine("Scanning: " + document);
        }
    }
}

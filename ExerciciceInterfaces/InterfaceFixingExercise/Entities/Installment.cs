using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFixingExercise.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Value { get; set; }

        public Installment(DateTime dueDate, double value)
        {
            DueDate = dueDate;
            Value = value;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy)"
                + " - "
                + Value.ToString("F2"),CultureInfo.InvariantCulture); 
        }
    }
}

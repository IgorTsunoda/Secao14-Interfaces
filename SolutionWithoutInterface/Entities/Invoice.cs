using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SolutionWithoutInterface.Entities
{
    internal class Invoice
    {
        public double BasicsPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicsPayment, double tax)
        {
            BasicsPayment= basicsPayment;
            Tax= tax;
        }
        public double TotalPayment
        {
            get { return BasicsPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicsPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotalPayment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

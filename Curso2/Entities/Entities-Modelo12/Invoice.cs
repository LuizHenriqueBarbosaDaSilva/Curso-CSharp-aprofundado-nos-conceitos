using Curso2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Model12
{
    public class Invoice
    {
        public double Tax { get; set; }
        public double BasicPayment { get; set; }

        public Invoice() { }
        public Invoice(double tax, double basicPayment)
        {
            Tax = tax;
            BasicPayment = basicPayment;
        }
        public double TotalPayment
        {
            get { return Tax + BasicPayment; }
        }
        public override string ToString()
        {
            return $"Basic Payment: {BasicPayment.ToString("F2",CultureInfo.InvariantCulture)}\nTax: {Tax.ToString("F2",CultureInfo.InvariantCulture)}\nTotal Payment: {TotalPayment.ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
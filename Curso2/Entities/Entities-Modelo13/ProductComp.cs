using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Entities_Modelo13
{
    internal class ProductComp : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductComp(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + $", {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public int CompareTo(Object obj)
        {
            if (!(obj is ProductComp))
            {
                throw new ArgumentException("Comparing erro: argument is not a Product");

            }
            ProductComp other = obj as ProductComp;
            return Price.CompareTo(other.Price);
        }
    }
}

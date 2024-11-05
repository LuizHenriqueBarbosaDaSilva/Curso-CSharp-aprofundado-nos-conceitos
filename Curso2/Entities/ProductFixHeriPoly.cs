using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class ProductFixHeriPoly
	{
		public string Name { get; set; }
		public decimal Price { get; set; }

		public ProductFixHeriPoly() { }
		public ProductFixHeriPoly(string name, decimal price) 
		{
			Name = name;
			Price = price;
		}

		public virtual string priceTag()
		{
            return $"{Name} $ {Price.ToString("F2",CultureInfo.InvariantCulture)}";
		}	
	}
}

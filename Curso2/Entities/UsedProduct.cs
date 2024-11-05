using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class UsedProduct : ProductFixHeriPoly
	{
		public DateTime ManufactureDate { get; set; }
		
		public UsedProduct() { }
		public UsedProduct(string name, decimal price, String manufactureDate) : base(name, price)
		{
			ManufactureDate = DateTime.ParseExact(manufactureDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
		}

		public override string priceTag()
		{
			return $"{Name} (used) $ {Price.ToString("F2",CultureInfo.InvariantCulture)} (Manufacture date:{ManufactureDate.ToString("dd/MM/yyyy")})";
		}
	}
}

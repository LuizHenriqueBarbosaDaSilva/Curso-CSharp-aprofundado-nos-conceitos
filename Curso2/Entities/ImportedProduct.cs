using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class ImportedProduct : ProductFixHeriPoly
	{
		public decimal CustomFee { get; set; }

		public ImportedProduct() { }
		public ImportedProduct(string name, decimal price, decimal customFee) : base (name,price)
		{
			CustomFee = customFee;
		}

		public override string priceTag()
		{
			return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Custom fee: $ {CustomFee.ToString("F2",CultureInfo.InvariantCulture)})";
		}
		public decimal TotalPrice()
		{
			return Price + CustomFee;
		}

	}
}

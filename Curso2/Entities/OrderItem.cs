using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class OrderItem
	{
		public int Quantity { get; set; }
		public double Price { get; set; }
		public Product ProductInfo { get; set; }

		public OrderItem() { }

		public OrderItem(int quantity, Product productInfo)
		{ 
			Quantity = quantity;
			ProductInfo = productInfo;
		}

		public double SubTotal()
		{
			return Price =  Quantity * ProductInfo.Price;
		}
	}
}

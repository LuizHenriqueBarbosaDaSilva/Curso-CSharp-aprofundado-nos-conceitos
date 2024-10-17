using Curso2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class Order
	{
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }
		public Client InformationClient { get; set; }
		public List<OrderItem> Products { get; set; } = new List<OrderItem>();

		public Order() { }

		public Order(DateTime moment, OrderStatus status, Client informationClient)
		{
			Moment = moment;
			Status = status;
			InformationClient = informationClient;
		}
		public void addItem(OrderItem item) { Products.Add(item); }
		public void removeItem(OrderItem item) { Products.Remove(item); }

		public double Total()
		{
			double sum = 0;
			foreach (OrderItem item in Products)
			{
				sum += item.SubTotal();
			}
			return sum;
		}

		public override string ToString()
		{

			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"""
			ORDER SUMMARY:
			Order moment: {Moment}
			Order status: {Status.ToString()}
			Client: {InformationClient.Name} {InformationClient.BirthDate} - {InformationClient.Email}
			Order items:
			""");
			foreach (OrderItem item in Products)
			{
				sb.AppendLine($"{item.ProductInfo.Name}, ${item.ProductInfo.Price.ToString("f2",CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2",CultureInfo.InvariantCulture)}");
			}
			sb.AppendLine($"Total price : ${Total().ToString("f2", CultureInfo.InvariantCulture)}");
			return sb.ToString();


		}
	}
}
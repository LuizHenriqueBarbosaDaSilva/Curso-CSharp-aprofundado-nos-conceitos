using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso2.Entities.Enums;

namespace Curso2.Entities
{
    class Order
	{
		public int Id { get; set; }
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }

		public override string ToString()
		{
			return $"""
				KeyId: {Id} | Moment: {Moment} | Status: {Status}
				""";	
		}
	}
}

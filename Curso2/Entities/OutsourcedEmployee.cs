using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class OutsourcedEmployee : Employee
	{
		public decimal AdditionalCharge {  get; set; }
		public OutsourcedEmployee(string name, int hours, decimal valuePerHour, decimal additionalCharge) : base(name, hours, valuePerHour)
		{
			AdditionalCharge = additionalCharge;
		}


		public override decimal Payment()
		{
			return base.Payment() + AdditionalCharge * 1.1m;
		}
	}
}

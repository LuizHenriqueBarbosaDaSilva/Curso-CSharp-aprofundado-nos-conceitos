using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class Employee
	{
		public string Name { get; set; }
		public int Hours { get; set; }
		public decimal ValuePerHour { get; set; }

		public Employee() { }
		public Employee(string name, int hours, decimal valuePerHour)
		{
			Name = name;
			Hours = hours;
			ValuePerHour = valuePerHour;
		}

		public virtual decimal Payment()
		{
			return ValuePerHour * Hours;
		}
	}
}

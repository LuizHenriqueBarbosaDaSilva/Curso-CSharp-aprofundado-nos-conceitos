using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso2.Entities.Enums;

namespace Curso2.Entities
{
	class Circle : Shape
	{
		public double Radius { get; set; }

		public Circle() { }

		public Circle(Color color, double radius) : base(color)
		{
			Radius = radius;
		}

		public override double Area()
		{
			return Math.PI * Radius * Radius;
		}
	}
}

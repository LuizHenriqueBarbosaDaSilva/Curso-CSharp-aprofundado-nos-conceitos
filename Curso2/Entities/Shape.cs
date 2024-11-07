using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso2.Entities.Enums;

namespace Curso2.Entities
{
	abstract class Shape
	{
		public Color Color { get; set; }

		public Shape() { }

		public Shape(Color color)
		{
			Color = color;
		}

		public abstract double Area();
	}
}

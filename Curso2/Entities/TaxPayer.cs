using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	abstract class TaxPayer
	{
		public string? Name { get; set; }
		public decimal AnualIncome { get; set; }
		
		public TaxPayer() { }
		public TaxPayer(string name, decimal anualIncome)
		{
			Name = name;
			AnualIncome = anualIncome;
		}

		public abstract decimal Tax();
	}
}

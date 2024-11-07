using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	class Individual : TaxPayer
	{
		public decimal HealthExpenditures { get; set; }

		public Individual() { }
		public Individual(string name, decimal anualIncome ,decimal healthExpenditures) : base(name,anualIncome) { HealthExpenditures = healthExpenditures; }

		public override decimal Tax()
		{
			if (AnualIncome < 20000.00m)
			{
				return (AnualIncome * 0.15m) - (HealthExpenditures * 0.50m);
			}
			else
			{
				return (AnualIncome * 0.25m) - (HealthExpenditures * 0.50m);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	class CompanyTax : TaxPayer
	{
		public int NumberOfEmployees { get; set; }

		public CompanyTax() { }
		public CompanyTax(string name, decimal anualIncome, int numberOfEmployees) : base(name, anualIncome) { NumberOfEmployees = numberOfEmployees; }
		public override decimal Tax()
		{
			if (NumberOfEmployees > 10)
			{
				return AnualIncome * 0.14m;
			}
			else
			{
				return AnualIncome * 0.16m;
			}
		}
	}
}

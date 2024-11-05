using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class BusinessAccount01 : Account01
	{
		public decimal LoanLimit { get; set; }

		public BusinessAccount01() { }

		public BusinessAccount01(int number, string holder, decimal balance, decimal loanLimit) : base(number, holder, balance)
		{
			LoanLimit = loanLimit;
		}

		public void Loan(decimal amount)
		{
			if (amount <= LoanLimit)
			{
				Balance += amount;
			}
		}
	}
}

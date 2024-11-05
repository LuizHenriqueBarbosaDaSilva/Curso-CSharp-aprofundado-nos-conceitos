using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	sealed class SavingAccount01 : Account01
	{
        public decimal InterestRate { get; set; }
		
		public SavingAccount01() { }

		public SavingAccount01(int number,string holder, decimal balance, decimal interestRate) : base(number,holder,balance) 
		{
			InterestRate = interestRate;
		}
		public void UpdateBalance() { Balance += Balance * InterestRate; }
		// Exemplo usando o override para nao ter taxa!
		/* 
		public override void Withdraw(decimal amount)
		{
			Balance -= amount;
		}
		*/
		// Exemplo usando o override para adcionar uma taxa de 2 a mais do balanço quando sacar!	
		public override void Withdraw(decimal amount)
		{
			base.Withdraw(amount);
			Balance -= 2.0m;
		}
	}
}

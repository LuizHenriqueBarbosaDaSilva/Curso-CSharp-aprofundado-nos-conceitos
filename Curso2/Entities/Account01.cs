using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class Account01
	{
		public int Number {  get; set; }
		public string Holder { get; set; }
		public decimal Balance { get; set; }

		public Account01() { }
		public Account01(int number, string holder, decimal balance) 
		{
			Number = number;
			Holder = holder;
			Balance = balance;
		}

		public virtual void Withdraw(decimal amount) { if (amount <= Balance) { Balance -= amount + 5.0m; } }
		public void Deposit(decimal amount) { Balance += amount; }

	}
}

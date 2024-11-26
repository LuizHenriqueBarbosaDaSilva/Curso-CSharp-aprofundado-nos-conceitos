using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
    /* 
    Exercicio de fixação 
    Fazer um programa para ler os dadosde uma conta bancaria e depois realizar um saque
    nesta conta bancaria, mostrando novo saldo. Um saque não pode ocorrer ou se não houver
    salvo na conta, ou se o valor do saque foi superior ao limite de saque da conta. Implemente a conta bancaria conforme projeto abaixo:

    Account
    - number : Integer
    - holder : String
    - balance: Double
    - withdrawLimit : Double
    + Methods
      + deposit(amount : Double) : void
      + withdraw(amount : Double) : void

    exemplo de erro:
    Enter account data
    Number: 8021
    Holder: Bob brown
    Initial balance: 200.00
    Withdraw limit: 300.00

    Enter amount for withdraw: 250.00
    Withdraw error: Not enough balance.

    */
    public class Account02
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; set; }
        public decimal WithdrawLimits { get; set; }

        public Account02() { }
        public Account02(int number, string holder, decimal balance, decimal withdrawLimits)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimits = withdrawLimits;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > WithdrawLimits)
            {
                throw new("The amount exceeds withdraw limits.");
            }
            else if (amount > Balance)
            {
                throw new("Not enough balance.");
            }
            Balance -= amount;

        }
        public void Deposit(decimal amount) { Balance += amount; }
        public override string ToString()
        {
            return $"Account:{Number}, holder:{Holder}, balance:{Balance}, withdraw limits:{WithdrawLimits}";
        }
    }
}

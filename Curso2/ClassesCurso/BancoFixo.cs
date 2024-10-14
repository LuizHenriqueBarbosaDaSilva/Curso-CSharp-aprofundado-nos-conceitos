using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
    /* Exercicio Fixação
Em um banco, para se cadastrar uma conta bancária, é necessario informar o numero da conta, o nome do titular da conta, e o valor de depósito
inicial que o titular depostiou ao abrir a conta. Este valor de depósito inicial, entretanto, é opocional, ou seja: se o titular não tiver
dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.

Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já o nome do titular pode ser alterado
(pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).

Por fim, o saldo da conta não pode ser alterado livremente. É preciso um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos
por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for 
suficiente para realizar o saque e/ou pagar a taxa.

Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial. Em seguida,
reralizar um depósit e depois um saque, sempre mostrando os dados da conta após cada operação
*/
    public class BancoFixo  
    {
        private string _nomeTitular;
        public int _numeroConta { get; private set; }
        public float _saldoDeposito { get; protected set; }
       

        // Construtor padrao
        public BancoFixo() { }
        // Construtor com as variaveis de inicio!
        public BancoFixo(string nomeTitular, int numeroConta)
        {
            _nomeTitular = nomeTitular;
            _numeroConta = numeroConta;
            _saldoDeposito = 0.0f;
        }
        // Construtor com o saldoDeposito
        public BancoFixo(string nomeTitular, int numeroConta, float saldoDeposito)
        {
            _nomeTitular = nomeTitular;
            _numeroConta = numeroConta;
            _saldoDeposito = saldoDeposito;
        }
        public string nomeTitular
        {
            get { return _nomeTitular; }
            set
            {
                if (value!= null && value.Length > 1)
                {
                    _nomeTitular = value;
                }
            }
        }

        public float DepositarSaldo(float SaldoNovo)
        {
            _saldoDeposito += SaldoNovo;
            return _saldoDeposito;
        }
        public float SaqueSaldo(float SaldoRetirar) 
        {
            float taxaSaldo = 5.00f;
            _saldoDeposito -= (SaldoRetirar + taxaSaldo);
            return _saldoDeposito;
        }

    } 
}

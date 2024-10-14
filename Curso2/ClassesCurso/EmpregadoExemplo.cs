using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
    public class EmpregadoExemplo
    {
        public string _Nome { get; set; }
        public decimal _Salario { get; set; }
        public int _Id { get; set; }
        public EmpregadoExemplo() { }
        public EmpregadoExemplo(int id, string nome , decimal salario)
        {
            if (nome != null)
            {
                _Nome = nome;
                _Salario = salario;
                _Id = id;
            }
            else { Console.WriteLine("Erro no sistema!"); }
                
        }
        public void SalarioNovo(decimal porcentagem)
        {
            _Salario += _Salario * porcentagem / 100.00m;
        }
        public override string ToString()
        {
            return $"""
            Id: {_Id} 
            Name: {_Nome}
            Salary: {_Salario.ToString("F2")}
            """;
        }

    }
}

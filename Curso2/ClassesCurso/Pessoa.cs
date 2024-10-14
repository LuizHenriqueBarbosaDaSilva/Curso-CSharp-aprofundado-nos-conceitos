using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
    public class Pessoa
    {
       
        public string _nome;
        public int _idade;
        public Pessoa() { }
        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public void Dados()
        {
            Console.Write("Nome:");
            _nome = Console.ReadLine();
            Console.Write("Idade:");
            _idade = int.Parse(Console.ReadLine());
        }
    }
}

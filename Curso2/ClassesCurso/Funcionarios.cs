using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
    public class Funcionarios
    {
        public string _nome;
        public float _salario;
        public void Dados()
        {
            Console.Write("Nome:");
            _nome = Console.ReadLine();
            Console.Write("Salario:");
            _salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}

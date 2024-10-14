using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
    public class ListaExemploProdutos
    {
        public string _nomeProduto { get; set; }
        public float _precoProduto { get; set; }

        public ListaExemploProdutos() { }
        public ListaExemploProdutos(string nomeProduto, float precoProduto) 
        {
            _nomeProduto = nomeProduto;
            _precoProduto = precoProduto;
        }

    }
}

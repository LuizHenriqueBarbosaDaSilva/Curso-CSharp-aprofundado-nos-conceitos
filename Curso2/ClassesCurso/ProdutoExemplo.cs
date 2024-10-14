using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
    public class ProdutoExemplo
    {
        private string _nome;
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }
        /**/
        public ProdutoExemplo() { }
        //Construtor que pede os argumentos para inciar
        //Nota: Para usar o construtor padrão caso tenha um construtor desse tipo abaixo, precisa escrever na classe o construtor padrão
        public ProdutoExemplo(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        //Sobrecarga do construtor
        public ProdutoExemplo(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }
        // Metodos para o Get e Set abaixo para acessar variaveis
        // public string GetNome() { return _nome; }
        //public void Setnome(string nome) { if (nome != null && nome.Length > 1) { _nome = nome; } }
        public string nome
        {
            get { return _nome; } 
            set {
                    if (nome != null && nome.Length > 1)
                    {
                        _nome = nome; 
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public override string ToString()
        {
            return $"{_nome}, ${_preco.ToString("F2",CultureInfo.InvariantCulture)}, {_quantidade} unidades. Total: ${ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
        }
        public void AdcionarProduto(int quantidadeNova)
        {
            _quantidade += quantidadeNova;
        }
        public void RemoverProduto(int quantidadeNova)
        {
            _quantidade -= quantidadeNova;
        }
    }
}

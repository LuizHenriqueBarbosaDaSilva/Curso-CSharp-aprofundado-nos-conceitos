using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Services.Services_Modelo13
{
    public class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void addValue(T value)
        {
            if (_count == 10) { throw new InvalidOperationException("PrintService is full!"); }
            _values[_count] = value;
            _count++;
        }

        public T first()
        {
            return _values[0];
        }

        public void print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write($"{_values[i]}, ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.Write("]\n");

        }
    }
}
/* Generics parte 1
- Generics permiutem que classes,interfaces e metodos possam ser parametrizados
por tipo. Seus benefícios são:
   : Reuso
   : Type Safety
   : Performance

- Uso comum: coleções.
Exemplo:
List<string> list = new List<string>();
list.Add("Maria");
string name = list[0];

Entendimento sobre o reuso com um problema motivador
Deseja-se fazer um program aque leia um conjunto de N numeros inteiros (N de 1 a 10)
,e depois imprima esses números de forma organizada conforme exemplo. Em seguida,
informar qual foi o primeiro valor informado.

Output: 		Criar um serviço de impressão
10			+ addValue(value : int) : Void
8			+ first() : Int
23			+ print() : Void 
[10, 8, 23]
First: 10

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
/* 03 
Fazer um programa para ler o nome de um aluno de as três notas que ele obteve nos três trismetres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no nao.
Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o minímo para ser aprovado (que é 60 pontos).
Você deve criar uma classe Aluno para resolver este problema.

Exemplo 1:                          Exemplo 2:
Nome do aluno: Alex Green            Nome do aluno: Alex Green
Digite as três notas do aluno:       Digite as três notas do aluno:
27.00                                17.00
31.00                                20.00
32.00                                15.00         
NOTA FINAL = 90.00                   NOTA FINAL = 52.00
APROVADO                             REPROVADO
                                     FALTARAM 8.00 PONTOS
 */
    public class SistemaNotaAluno
    {
        public string _nome;
        public float _nota1,_nota2,_nota3;
    
        public float NotaFinal() { return (_nota1 + _nota2 + _nota3); }
        public void VerificaSePassou()
        {
            Console.WriteLine($"NOTA FINAL {NotaFinal().ToString("F2")}");
            if (NotaFinal() >= 60.00) { Console.WriteLine("Aprovado"); }
            else
            {
                Console.WriteLine($"REPROVADO \nFALTARAM {(60.00 - NotaFinal()).ToString("F2")} PONTOS");
            }
        }
    }
}

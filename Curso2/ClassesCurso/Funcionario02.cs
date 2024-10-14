using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
/* 02
Fazer um programa para ler os dados de um funcionário (nome,salário bruto e imposto). Em
seguida, mostrar os dados do funcionário (nom e salário líquido). Em seguida, aumentar o salário bruto  +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+   
é afetado pela porcentagem e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.  |  Funcionario	                              |
                                                                                                        +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
Exemplo:                                                                                                | - Nome: String                              |
Nome: Joao Silva                                                                                        | - SalarioBruto: double                      |
Salário bruto: 6000.00                                                                                  | - Imposto: double                           |
Imposto:1000.00                                                                                         +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
                                                                                                        | + SalarioLiquído() double                   |
Funcionário: Joao Silva, $ 5000.00                                                                      | + AumentarSalario(double porcentagem) void  |
Digite a porcentagem para aumentar o salário: 10.0                                                      +-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+

Dados atualizados: Joao Silva, $ 5600.00
 */
    public class Funcionario02
    {
        public string _nome;
        public double _salarioBruto;
        public double _imposto;
        
        public double SalarioLiquido() { return _salarioBruto - _imposto; }
        public void AumentarSalario(double _porcentagem)
        {
            _salarioBruto += _salarioBruto * (_porcentagem / 100.0);
        }
        public override string ToString()
        {
            return $"{_nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

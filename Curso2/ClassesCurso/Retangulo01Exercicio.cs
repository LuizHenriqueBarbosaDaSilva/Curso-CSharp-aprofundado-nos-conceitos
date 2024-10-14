using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.ClassesCurso
{
/* 01 									                                    
Fazer um programa para ler os valores da largura e altura de um retangulo.   +-=-=-=-=-=-=-=-=-=-=-=-+
Em seguida, mostrar na tela o vaoor de sua area, perimetro e diagonal.	     |  Retangulo  	         |
Usar uma classe como mostrado no projeto ao lado!		                     +-=-=-=-=-=-=-=-=-=-=-=-+
                                                                             | - Lagura: double	     |
Exemplo:		    						                                 | - Altura: double      |
Entre a largura e altura do retangulo:					                     +-=-=-=-=-=-=-=-=-=-=-=-+
                                                                             | + Area(): double      |
3.00									                                     | + Perimetro(): double |
4.00									                                     | + Diagonal(): double  |
AREA = 12.00			    				                                 +-=-=-=-=-=-=-=-=-=-=-=-+
PERÍMETRO = 14.00						             
DIAGONAL = 5.00
*/
    public class Retangulo01Exercicio
    {
        public double _largura,_altura;
    
        public double Area() { return  _largura * _altura; }
        public double Perimetro() { return 2 * (_largura + _altura); }
        public double Diagonal() 
        { 
            double diagonalSemRaiz = Math.Pow(_largura,2) + Math.Pow(_altura,2);
            return  Math.Sqrt(diagonalSemRaiz);      
        }
    }
}

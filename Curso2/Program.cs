// See https://aka.ms/new-console-template for more information
using Curso2.Entities;
using Curso2.Entities.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Principal;
using System.Globalization;
using Curso2.Entities.Entities_Model12;
using Curso2.Entities.Services;
using System;
using System.Diagnostics.Contracts;
using Course.Entities;
using Curso2.Entities.Entities_Modelo12;
using Curso2.Entities.Services.Services_Modelo13;
using Curso2.Entities.Entities_Modelo13;
using Curso2.Entities.Entities_Modelo15;
using System.Linq;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hora de fazer o curso dois!");
/* 00 Preludio
 Fazer um programa para executar a seguinte interação com o usuario, lendo os valores destacados em vermelho e depois, mostrar os dados na tela

 Entrada:                                                   | Saida:
 Entre com seu nome completo:                               | Alex Green
 Alex Green                                                 | 3
 Quantos quartos tem na sua casa?                           | 500.50
 3                                                          | Green
 Entre com o preço de um produto:                           | 21
 500.50                                                     | 1.73
 Entre com seu ultimo nome, idade e altura (mesma linha):   |
 Green 21 1,73                                              |

int idade, quartos;
string nome, ultimo_nome;
float altura;
double preco;

Console.WriteLine("Entre com seu nome completo:");
nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto completo:");
preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com seu ultimo nome,idade e altura");
string[] box = Console.ReadLine().Split();
ultimo_nome = box[0];
idade = int.Parse(box[1]);
altura = float.Parse(box[2]);

Console.WriteLine($"{nome}\n{quartos}\n{preco.ToString("F2", CultureInfo.InvariantCulture):F2}\n{ultimo_nome}\n{idade}\n{altura.ToString("F2", CultureInfo.InvariantCulture)}");
 */
// Exercicios propostos abaixo Correções: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1002/uri1002/Program.cs
/* 01
Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
mensagem explicativa, conforme exemplos.

Exemplos:
Entrada:            | Saída:         Entrada:            | Saída:           Entrada:      | Saída:
10                  | SOMA = 40      -30                 | SOMA = -20       0             | SOMA = 0
30                  |                10                  |                  0             |


int num1 = int.Parse(Console.ReadLine()),num2 = int.Parse(Console.ReadLine()), soma = num1 + num2;
Console.WriteLine(soma);
 */
/* 02
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
    Fórmula da área: area = π . raio2
    Considere o valor de π = 3.14159

Exemplos:
Entrada:            | Saída:            Entrada:            | Saída:            Entrada:            | Saída:
2.00                | A=12.5664         100.64              | A=31819.3103      150.00              |A=70685.7750 

float pi = 3.14159F, raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), A = pi * (raio*raio);
Console.WriteLine(A.ToString("F4"));
*/
/* 03
Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Exemplos:
Entrada:    | Saída:                 Entrada:    | Saída:             
5           | DIFERENCA = -26        5           | DIFERENCA = 86                     
6           |                        6           |                              
7           |                        -7          |
8           |                        8           |

int A = int.Parse(Console.ReadLine()), B = int.Parse(Console.ReadLine()), C = int.Parse(Console.ReadLine()), D = int.Parse(Console.ReadLine()), diferenca = ((A * B) - (C * D));
Console.WriteLine(diferenca);
*/
/* 04
Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Exemplos:
Entrada:        | Saída:                   Entrada:       | Saida:                      Entrada:       | Saída:
25              | NUMBER = 25              1              | NUMBER = 1                  6              | NUMBER = 6
100             | SALARY = U$ 550.00       200            | SALARY = U$ 4100.00         145            | SALARY = U$ 2254.75
5.50            |                          20.50          |                             15.55          |

int numero = int.Parse(Console.ReadLine()), horasTrabalhadas = int.Parse(Console.ReadLine());
float salarioPorHora  = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), Salario = salarioPorHora * horasTrabalhadas;
Console.Write($"NUMBER = {numero}\nSALARY = U$ {Salario.ToString(CultureInfo.InvariantCulture)}");
*/
/* 05
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

Exemplos:
Entrada:        | Saída:                    Entrada:       | Saida:                      Entrada:       | Saída:
12 1 5.30       | VALOR A PAGAR: R$ 15.50   13 2 15.30     | VALOR A PAGAR: R$ 51.40     1 1 15.10      | VALOR A PAGAR: R$ 30.20
16 2 5.10       |                           161 4 5.20     |                             2 1 15.10      |

string[] pecas1 = Console.ReadLine().Split(' '), pecas2 = Console.ReadLine().Split(' ');
int codigo1Peca = int.Parse(pecas1[0]), codigo2Peca = int.Parse(pecas2[0]), num1Peca = int.Parse(pecas1[1]), num2Peca = int.Parse(pecas2[1]);
float valor1Peca = float.Parse(pecas1[2],CultureInfo.InvariantCulture), valor2Peca = float.Parse(pecas2[2],CultureInfo.InvariantCulture), valorPagar = (valor1Peca * num1Peca) + (valor2Peca * num2Peca);
Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar.ToString("F2",CultureInfo.InvariantCulture)}");
*/
/* 06
 Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.

Exemplos:
Entrada:         | Saída:                   Entrada:         | Saída:
3.0 4.0 5.2      | TRIANGULO: 7.800         12.7 10.4 15.2   | TRIANGULO: 96.520
                 | CIRCULO: 84.949                           | CIRCULO: 725.833
                 | TRAPEZIO: 18.200                          | TRAPEZIO: 175.560
                 | QUADRADO: 16.000                          | QUADRADO: 108.160
                 | RETANGULO: 12.000                         | RETANGULO: 132.080

string[] box = Console.ReadLine().Split(' ');
float pi = 3.14159F,numA = float.Parse(box[0],CultureInfo.InvariantCulture), numB = float.Parse(box[1],CultureInfo.InvariantCulture), numC = float.Parse(box[2],CultureInfo.InvariantCulture);
float AreTriRet = numA * numC / 2, AreCirRai = pi * numC * numC, AreTra = (numA + numB) * numC/2, AreQua = numB * numB, AreRet = numA * numB;
Console.Write($"TRAINGULO: {AreTriRet.ToString("F3",CultureInfo.InvariantCulture)}\nCIRCULO: {AreCirRai.ToString("F3",CultureInfo.InvariantCulture)}\nTRAPEZIO: {AreTra.ToString("F3",CultureInfo.InvariantCulture)}\n");
Console.Write($"QUADRADO: {AreQua.ToString("F3",CultureInfo.InvariantCulture)}\nRETANGULO: {AreRet.ToString("F3",CultureInfo.InvariantCulture)}");
 */
// Exercícios Propostos 2 - sobre Estrutura Condicional (if-else)
/* 01 
Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

Exemplos:
Entrada:        | Saída:        Entrada:        | Saída:            Entrada:        | Saída:
-10             | NEGATIVO      8               | NAO NEGATIVO      0               | NAO NEGATIVO

int num0 = int.Parse(Console.ReadLine());
if (num0 >= 0){ Console.WriteLine("NAO NEGATIVO"); } else { Console.WriteLine("NEGATIVO"); }
 */
/* 02 
Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

Exemplos:
Entrada:        | Saída:        Entrada:        | Saída:            Entrada:        | Saída:
12              | PAR           -27             | IMPAR             0               | PAR

int num0 = int.Parse(Console.ReadLine());
if (num0 % 2 == 0) { Console.WriteLine("PAR"); } else { Console.WriteLine("IMPAR"); }
 */
/* 03
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.

Exemplos:
Entrada:       | Saída:                 Entrada:       | Saída:                 Entrada:       | Saída:
6 24           | Sao Multiplos          6 25           | Nao sao Multiplos      24 6           | Sao Multiplos 

string[] box = Console.ReadLine().Split(' ');
int Num1 = int.Parse(box[0]),Num2 = int.Parse(box[1]);
if (Num1 % Num2 == 0 || Num2 % Num1 == 0) { Console.WriteLine("Sao Multiplos"); } else { Console.WriteLine("Nao sao Multiplos"); }
 */
/* 04 
Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

Exemplos:
Entrada:    | Saída:                     Entrada:    | Saída:                     Entrada:    | Saída:
16 2        | O JOGO DUROU 10 HORA(S)    0 0         | O JOGO DUROU 24 HORA(S)    2 16        | O JOGO DUROU 14 HORA(S)

string[] box = Console.ReadLine().Split(' ');
int HoraInicio = int.Parse(box[0]), HoraTermino = int.Parse(box[1]);
if (HoraInicio == 0 && HoraTermino == 0) { Console.WriteLine("O JOGO DUROU 24 HORA(S)"); } else if (HoraInicio > HoraTermino ) { Console.WriteLine($"O JOGO DUROU {(24 - HoraInicio) + HoraTermino} HORAS(S)"); }
else { Console.WriteLine($"O JOGO DUROU {HoraTermino - HoraInicio} HORAS(S)"); }
*/
/* 05
 Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.

CODIGO  | ESPEFICIAÇÃO    | PREÇO
1       | Cachoror quente | R$ 4.00
2       | X-Salada        | R$ 4.50
3       | X-Bacon         | R$ 5.00
4       | Torrada Simpels | R$ 2.00
5       | Refrigerante    | R$ 1.50

Exemplos:
Entrada:    | Saída:                     Entrada:    | Saída: 
3 2         | Total: R$ 10.00            2 3         | Total: R$ 13.50

Console.Write($"""
    CODIGO  | ESPEFICIAÇÃO    | PREÇO
    1       | Cachoror quente | R$ 4.00
    2       | X-Salada        | R$ 4.50
    3       | X-Bacon         | R$ 5.00
    4       | Torrada Simpels | R$ 2.00
    5       | Refrigerante    | R$ 1.50

    """);
string[] box = Console.ReadLine().Split(' ');
int Prod = int.Parse(box[0]), Quantia = int.Parse(box[1]);
float resultado;
switch (Prod)
{
    case 1:
        resultado = Quantia * 4.00F;
        Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        break;
    case 2:
        resultado = Quantia * 4.50F;
        Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        break;
    case 3:
        resultado = Quantia * 5.00F;
        Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        break;
    case 4:
        resultado = Quantia * 2.00F;
        Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        break;
    case 5:
        resultado = Quantia * 1.00F;
        Console.WriteLine($"Total: R$ {resultado.ToString("F2")}");
        break;
}
 */
/* 06
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

Exemplos
Entrada:    | Saída:                     Entrada:    | Saída:                     Entrada:    | Saída:                     Entrada:    | Saída:
25.01       | Intervalo (25,50]          25.00       | Intervalo [0,25]           100.00      | Intervalo (75,100]         -25.02      | Fora de intervalo

float num1 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
if (num1 >= 0 && num1 <= 25.00) { Console.WriteLine("Intervalo [0,25]"); } else if (num1 > 25.00 && num1 <= 50.00) { Console.WriteLine("Intervalo (25,50] "); }
else if  (num1 > 50.00 && num1 <= 75.00) { Console.WriteLine("Intervalo (50,75] "); } else if (num1 > 75.00  && num1 <= 100.00) { Console.WriteLine("Intervalo (75,100]"); }
else { Console.WriteLine("Fora de intervalo"); }
 */
/* 07 
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação.
          
            | y
            |
        Q2  |  Q1
            |       x
     -------|-------
            |
        Q3  |  Q4
            |
            |
Exemplos:
Entrada:    | Saída:        Entrada:    | Saída:       Entrada:    | Saída:      
4.5 -2.2    | Q4            0.1 0.1     | Q1           0.0 0.0     | Origem 

string[] box = Console.ReadLine().Split(' ');
float posX = float.Parse(box[0],CultureInfo.InvariantCulture), posY = float.Parse(box[1],CultureInfo.InvariantCulture);
if (posX > 0 && posY > 0) { Console.WriteLine("Q1"); } else if (posX > 0 && posY < 0) { Console.WriteLine("Q4"); } else if (posX < 0 && posY > 0) { Console.WriteLine("Q2"); } 
else if (posX < 0 && posY < 0) { Console.WriteLine("Q3"); } else { Console.WriteLine("Origem"); }
 */
/* 08
Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.

Renda                           | Imposto de Renda
de 0.00 a R$ 2000.00            | Isento
de R$ 2000.01 até R$ 3000.00    | 8%
de R$ 3000.01 até R$ 4500.00    | 18%
acima de R$ 4500.00             | 28%


Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
duas casas decimais.

Exemplos:
Entrada:    | Saída:        Entrada:    | Saída:       Entrada:    | Saída:    
3002.00     | R$ 80.36      1701.12     | Isento       4520.00     | R$ 355.60
 
double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture), imposto = 0.0;

if (salario <= 2000.00)
{
    Console.WriteLine("Isento");
}
else if (salario <= 3000.00)
{
    imposto = (salario - 2000.00) * 0.08;
    Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
}
else if (salario <= 4500.00)
{
    imposto = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);
    Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
}
else
{
    imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
    Console.WriteLine($"R$ {imposto.ToString("F2",CultureInfo.InvariantCulture)}");
}
*/
// Exercícios sobre Estrutura Repetitiva WHILE
/* 01
 Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

Exemplo:
Entrada:    | Saída:
2200        | Senha Invalida
1020        | Senha Invalida
2022        | Senha Invalida
2002        | Acesso Permitido

while (true)
{
    int numeroSerie = int.Parse(Console.ReadLine());
    if (numeroSerie == 2002)
    {
        Console.WriteLine("Acesso permitido");
        break;
    }
    else
    {
        Console.WriteLine("Senha Invalida");
    }
}
*/
/* 02 
Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

Exemplo:
Entrada:    | Saída:
2 2         | primeiro
3 -2        | quarto
-8 -1       | terceiro
-7 1        | segundo
0 2         |

while (true)
{
    string[] caixa = Console.ReadLine().Split(' ');   
    int x = int.Parse(caixa[0]);
    int y = int.Parse(caixa[1]);
    if (x == 0 || y == 0) { break; } else if (x > 0 && y > 0) { Console.WriteLine("prmeiro"); } else if (x < 0 && y > 0) { Console.WriteLine("segundo"); }
    else if (x < 0 && y < 0) { Console.WriteLine("terceiro"); } else if (x > 0 && y < 0) { Console.WriteLine("quarto"); }
}
*/
/* 03 
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.

Exemplo:
Entrada:    | Saída:
8           | MUITO OBRIGADO
1           | Alcool: 1
7           | Gasolina: 2
2           | Diesel: 0
2           |
4           |

int votoNumero, votoAlcool = 0,votoGasolina = 0,votoDiesel = 0; 
while (true)
{
    votoNumero = int.Parse(Console.ReadLine());
    if (votoNumero == 4) { break; } else if (votoNumero == 1) { votoAlcool++; } else if (votoNumero == 2) { votoGasolina++; } else if (votoNumero == 3) { votoDiesel++; }
}
Console.Write($"MUITO OBRIGADO\nAlcool:{votoAlcool}\nGasolina:{votoGasolina}\nDiesel:{votoDiesel}");
*/
// Exercicios for
/* 01 
Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

Exemplo:
Entrada:    | Saída:
8           | 1
            | 3
            | 5
            | 7

int x = int.Parse(Console.ReadLine());
if (1 <= x &&  x <= 1000)
{
    for (int i = 1; i < x; i++)
    {
        Console.WriteLine(i);
    }
}
*/
/* 02 
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

Exemplo:
Entrada:    | Saída:
5           | 2 in
14          | 3 out
123         |
10          |
-25         |
32          |

int num1 = int.Parse(Console.ReadLine()), conIn = 0, conOut = 0;
for  (int i = 0; i < num1; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (x >=10 && x <= 20)
    {
        conIn++;
    }
    else
    {
        conOut++;
    }
}
Console.Write($"{conIn} in\n{conOut} out");
*/
/* 03
Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.

Exemplo:
Entrada:        | Saída:
3               | 5.7
6.5 4.3 6.2     | 6.3
5.1 4.2 8.1     | 9.3 
8.0 9.0 10.0    |

int num1 = int.Parse(Console.ReadLine());
for  (int i = 0; i < num1; i++)
{
    string[] caixa = Console.ReadLine().Split(' ');
    float nota1 = float.Parse(caixa[0],CultureInfo.InvariantCulture), nota2 = float.Parse(caixa[1], CultureInfo.InvariantCulture), nota3 = float.Parse(caixa[2], CultureInfo.InvariantCulture),media = ( nota1 * 2 + nota2 * 3  + nota3 * 5 ) / ( 2 + 3 + 5 );
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}
*/
/* 04
Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

Exemplo:
Entrada:    | Saída:
3           | -1.5
3 -2        | divisao impossivel
-8 0        | 0.0
0 8        

int num1 = int.Parse(Console.ReadLine());
for  (int i = 0; i < num1; i++)
{
    string[] caixa = Console.ReadLine().Split(' ');
    float x = float.Parse(caixa[0], CultureInfo.InvariantCulture), y = float.Parse(caixa[1], CultureInfo.InvariantCulture);
    if (y == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        float divisao = x / y;
        Console.WriteLine(divisao.ToString("F1",CultureInfo.InvariantCulture));
    }
}
*/
/* 05
 Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.

Exemplos:
Entrada: | Saída:   Entrada: | Saída:   Entrada: | Saída:   Entrada: | Saída:
4        | 24       1        | 1        5        | 120      0        | 1

int n = int.Parse(Console.ReadLine()),fat = 1;
for (int i = 1; i <= n; i++)
{ 
    fat = fat * i;
}
Console.WriteLine(fat);
*/
/* 06
Ler um número inteiro N e calcular todos os seus divisores.

Exemplo:
Entrada: | Saída:
6        | 1
         | 2
         | 3
         | 6

int n = int.Parse(Console.ReadLine());
for  (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}
*/
/* 07 
Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
exemplo.

Exemplo:
Entrada:  | Saída:
5         | 1 1 1
          | 2 4 8
          | 3 9 27
          | 4 16 64
          | 5 25 125

int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} {i*i} {i*i*i}");
}
*/
// Exericicos de classe - primeiros
/* 01:
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

Exemplo:
Dados da primeira pessoa:
Nome: Maria
Idade: 17
Dados da segunda pessoa:
Nome: Joao
Idade: 16
Pessoa mais velha: Maria

Pessoa primeiraPessoa = new Pessoa(), segundaPessoa = new Pessoa();
primeiraPessoa.Dados();
segundaPessoa.Dados();

Console.Write($"Dados da primeira pessoa:\nNome:{primeiraPessoa._nome}\nIdade:{primeiraPessoa._idade}\nDados da segunda pessoa:\nNome:{segundaPessoa._nome}\nIdade:{segundaPessoa._idade}\n");
if (primeiraPessoa._idade > segundaPessoa._idade)
{
    Console.WriteLine($"Pessoa mais velha:{primeiraPessoa._nome}");
}
else
{
    Console.WriteLine($"Pessoa mais velha:{segundaPessoa._nome}");
}
 */
/* 02
Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
médio dos funcionários.

Exemplo:
Dados do primeiro funcionário:
Nome: Carlos Silva
Salário: 6300.00
Dados do segundo funcionário:
Nome: Ana Marques
Salário: 6700.00
Salário médio = 6500.00

Funcionarios primFuncionario = new Funcionarios(), seguFuncionario = new Funcionarios();
Console.Write("Dados da primeiro funcionário:\n");
primFuncionario.Dados();
Console.Write("Dados da segunda pessoa:\n");
seguFuncionario.Dados();

float salarioMedia = (primFuncionario._salario + seguFuncionario._salario)/2;
Console.Write($"Salário médio = {salarioMedia.ToString("F2", CultureInfo.InvariantCulture)}");
*/
// Demonstração de ToString() em metodo!
/* Produto 

ProdutoExemplo item = new ProdutoExemplo();

Console.Write("Entre os dados do produto:  \nNome: ");
item._nome = Console.ReadLine();
Console.Write("Preço: ");
item._preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
item._quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"\nDados do produto: {item.ToString()}\n");
Console.Write("Digite o numéro de produtos a ser adcionado ao estoque:");
int qte = int.Parse(Console.ReadLine());
item.AdcionarProduto(qte);

Console.WriteLine($"\nDados do produto: {item.ToString()}\n");
Console.Write("Digite o numéro de produtos a ser adcionado ao estoque:");
qte = int.Parse(Console.ReadLine());
item.RemoverProduto(qte);

Console.WriteLine($"\nDados do produto: {item.ToString()}\n");
 */
// Exercicio Classes 02
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

Retangulo01Exercicio iTem = new Retangulo01Exercicio();
iTem._largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   
iTem._altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write($"AREA = {iTem.Area().ToString("F2",CultureInfo.InvariantCulture)} \nPERÍMETRO = {iTem.Perimetro().ToString("F2", CultureInfo.InvariantCulture)} \nDIAGONAL = {iTem.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
*/
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

Funcionario02 iTem = new Funcionario02();
Console.Write($"Nome:");
iTem._nome = Console.ReadLine();
Console.Write($"Salário bruto:");
iTem._salarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write($"Imposto:");
iTem._imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write($"\nFuncionário: {iTem.ToString()}\n");
Console.Write($"Digite a porcentagem para aumentar o salário:");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
iTem.AumentarSalario(porcent);
Console.WriteLine($"\nDados atualizados: {iTem.ToString()}");
 */
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

SistemaNotaAluno iTem = new SistemaNotaAluno();
Console.Write("Nome do aluno: ");
iTem._nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
iTem._nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
iTem._nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
iTem._nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
iTem.VerificaSePassou();  
*/
// Membros estaticos!
// A parte 01 e 02 são iguais so muda que a dois é numa classe e não aqui é ela tambem é chamada de calculadora
/* Parte 01 

Console.WriteLine("Entre o valor do raio:");
double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double circ = MetodosStaticosExemplos.Circuferencia(raio), volu = MetodosStaticosExemplos.Volume(circ) ;
Console.WriteLine($"Circuferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}\nVolume: {volu.ToString("F2",CultureInfo.InvariantCulture)}");
Console.WriteLine($"Valor de Pi: {MetodosStaticosExemplos._pi.ToString("F2",CultureInfo.InvariantCulture)}");
 */
/* Parte 03 - Exercicio

Faça um programa para ler a cotação do dolar, e depois um valor em dolars a ser comprado por uma pessoa em reais.Informr quanto reias a pessoa
vai pagar pelos dólares, considerando ainda que a pessoa terá que pegar 6% de OF sobre o valor em dòlar. Criar uma classe ConversorDeMoeda
para ser responsavel pelos cálculos
 
 */
// Demonstração de metodo construtor
/* Produto construtor

Console.Write("Entre os dados do produto:  \nNome: ");
string nomeAux = Console.ReadLine();
Console.Write("Preço: ");
double precoAux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
int quantidadeAux = int.Parse(Console.ReadLine());

ProdutoExemplo p = new ProdutoExemplo(nomeAux,precoAux,quantidadeAux);

Console.WriteLine($"\nDados do produto: {p.ToString()}\n");
Console.Write("Digite o numéro de produtos a ser adcionado ao estoque:");
int qte = int.Parse(Console.ReadLine());
p.AdcionarProduto(qte);

Console.WriteLine($"\nDados do produto: {p.ToString()}\n");
Console.Write("Digite o numéro de produtos a ser adcionado ao estoque:");
qte = int.Parse(Console.ReadLine());
p.RemoverProduto(qte);

Console.WriteLine($"\nDados do produto: {p.ToString()}\n");
 */
// Demonstração de Sobrecarga do construtor
/* Sobrecarga construtor
Console.Write("Entre os dados do produto:  \nNome: ");
string nomeAux = Console.ReadLine();
Console.Write("Preço: ");
double precoAux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// Quantidade ja existe e vira 5
ProdutoExemplo p = new ProdutoExemplo(nomeAux,precoAux);

Console.WriteLine($"\nDados do produto: {p.ToString()}\n");
Console.Write("Digite o numéro de produtos a ser adcionado ao estoque:");
int qte = int.Parse(Console.ReadLine());
p.AdcionarProduto(qte);

Console.WriteLine($"\nDados do produto: {p.ToString()}\n");
Console.Write("Digite o numéro de produtos a ser adcionado ao estoque:");
qte = int.Parse(Console.ReadLine());
p.RemoverProduto(qte);

Console.WriteLine($"\nDados do produto: {p.ToString()}\n");
 */
// Nota se não houver construtores para instanciar variaveis voce pode fazer o seguinte
/* Exemplo nota 
ProdutoExemplo p = new ProdutoExemplo() 
{ 
    _nome = "TV - panasonic",
    _preco = 900.0,
    _quantidade = 0,

};
ProdutoExemplo p2 = new ProdutoExemplo()
{
    _nome = "TV - philips",
    _preco = 1000.0,
    _quantidade = 1,
};
*/
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

Exemplo 1:
Entre o número da conta: 8532
Entre com o titular da conta: Alex Green
Haverá depósito inicial (s/n)? s
Entre o valor de depósito inicial: 500.00

Dados da conta:
Conta 8532, Titular: Alex Green, Saldo: $ 500.00

Entre um valor para depósito:200.00
Dados da conta atualizados:
Conta 8352, Titular: Alex Green, Saldo: $ 700.00

Entre um valor para saque: 300.00
Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 395.00

Exemplo 2:
Entre o número da conta:7801
Entre o titular da conta: Maria Brown
Haverá depósito inicial (s/n)? n

Conta 7801, Titular: Maria Brown, Saldo: $ 0.00

Entre um valor para depósito:200.00
Dados da conta atualizados:
Conta 7801, Titular: Maria Brown, Saldo: $ 200.00

Entre um valor para saque: 198.00
Dados da conta atualizados:
Conta 7801, Titular: Maria Brown, Saldo: $ -3.00

Console.Write("Entre o número da conta: ");
int numConta = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da conta: ");
string nomConta = Console.ReadLine();
Console.Write("Haverá um deposito inicial (s/n)? ");
char conFirm = char.Parse(Console.ReadLine());

BancoFixo contaCliente = null;
if (conFirm.ToString().ToLower() == "s") 
{
    Console.Write("Entre o valor de depósito inicial: ");
    float depConta = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    contaCliente = new BancoFixo(nomConta, numConta, depConta);
}
else if (conFirm.ToString().ToLower() == "n")
{
    contaCliente = new BancoFixo(nomConta, numConta);
}
else { Console.WriteLine("Opção invalida!"); }

Console.WriteLine("\nDados da conta:");
Console.WriteLine($"Conta {contaCliente._numeroConta}, Titular: {contaCliente.nomeTitular}, Saldo: $ {contaCliente._saldoDeposito.ToString("F2",CultureInfo.InvariantCulture)}");

Console.Write("Entre um valor para um depósito: ");
float depDepoisConta = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
contaCliente.DepositarSaldo(depDepoisConta);

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine($"Conta {contaCliente._numeroConta}, Titular: {contaCliente.nomeTitular}, Saldo: $ {contaCliente._saldoDeposito.ToString("F2",CultureInfo.InvariantCulture)}");

Console.Write("Entre com um valor para o saque: ");
float saqueConta = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
contaCliente.SaqueSaldo(saqueConta);

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine($"Conta {contaCliente._numeroConta}, Titular: {contaCliente.nomeTitular}, Saldo: $ {contaCliente._saldoDeposito.ToString("F2",CultureInfo.InvariantCulture)}");

*/
// Exemplo Classe Listas
/* 
int n = int.Parse(Console.ReadLine());

ListaExemploProdutos[] vetores =  new ListaExemploProdutos[n];

for (int i = 0; i < n; i++)
{
    string produto = Console.ReadLine();
    float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vetores[i] = new ListaExemploProdutos(produto, valor);
}

float sum = 0.0f;
for (int i = 0;i < n; i++)
{
    sum += vetores[i]._precoProduto;
}

float result = sum / n;
Console.WriteLine($"O preço entre os produtos e de:{result.ToString("F2",CultureInfo.InvariantCulture)}");
*/
// Exercicio de Fixação listas
/* 
Console.Write($"How many rooms will be rented? ");
int rents = int.Parse(Console.ReadLine());
HotelExemplo[] salas = new HotelExemplo[rents];


for (int i = 0; i < rents; i++)
{
    Console.WriteLine($"rent #{i+1}:");
    Console.Write($"Name: ");
    string nome = Console.ReadLine();
    Console.Write($"Email: ");
    string email = Console.ReadLine();
    Console.Write($"Room: ");
    int room = int.Parse(Console.ReadLine());

    salas[i] = new HotelExemplo(nome,email,room);
}
Console.WriteLine("Busy Rooms:");
foreach (HotelExemplo sala in salas)
{
    if (sala != null)
    {
        Console.WriteLine($"{sala._Room}: {sala._Nome}, {sala._Email}");
    }
}
*/
// Modificadores de parâmetros Exemplo!
/* 
public static int[] Sum(int[] numbers){
    int sum = 0;
    for (int i = 0; i < numbers.length; i++){
        sum +=  numbers[i];
    }
    return sum;
}
*/
// Modificadores de parametros: Ref Exemplo!
/* 
 Na classe!
public class Calculadora 
{
    public static int Triple(ref int _X) // Ref passa qualquer coisa que foi feita na varivavel que serviu como argumento para operação dentro da classe
    {
        x = x * 3;
    }

}
No program main!
int a = int.Parse(Console.ReadLine()); // Insere 10

Calculadora.Triple(ref a); // passa 10 la pra dentro e por causa do ref ira retornar a variavel [a] como 30!
Console.WriteLine(a);

 
 */
// Modificadores de parametros: Out Exemplo!
/*
Nota: Out serve igual o Ref mas voce cria uma variavel para guardar o resultado de dentro da função
Na Classe!
public class Calculadora 
{
    public static void Triple(int _origem, out int _resultado) // Parametro de entrada, parametro de saida
    {
        result = origin * 3;
    }
}

No program!
int a = 10;
int triple;

Calculator.Triple(a,out triple); // Parametro de entrada, parametro de saida
Console.WriteLine(triple);
 */
// Exercicio de fixação lista
/* 
Fazer um programa para ler um  numero inteiro N e depois os dados (id,nome e salario) de N funcionarios. Nao deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salario de um determinado funcionario. Para isso, o programa deve ler um id e o valor X. 
Se o id informado nao existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atuaizada dos funcionarios, conforme exemplos.

Lembre-se de aplicar a tecnica de encapsulamento para não permitir que o salario possa ser mudado liveremente. 
Um salario so pode ser aumentando com base em uma operação de aumento por porcentagem dada

List<EmpregadoExemplo> ListaEmpregados = new List<EmpregadoExemplo>();
Console.Write($"How many employees will be registred? ");
int n = int.Parse(Console.ReadLine());  

for  (int i = 0; i < n ; i++)
{
    int IdEmpregado = int.Parse((Console.ReadLine()));
    string NomeEmpregado = Console.ReadLine();
    decimal SalarioEmpregado = decimal.Parse(Console.ReadLine());

    ListaEmpregados.Add(new EmpregadoExemplo(IdEmpregado,NomeEmpregado,SalarioEmpregado));
}


for  (int i = 0;i < n ; i++)
{
    Console.WriteLine($"Employee #{i+1}");
    Console.WriteLine(ListaEmpregados[i].ToString());
}

Console.Write("Enter the employee id that will have the salary increase : ");
int IdBuscador = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    if (ListaEmpregados[i]._Id == IdBuscador)
    {
        Console.Write("Enter with the percentage :");
        decimal porcentagem = decimal.Parse(Console.ReadLine());

        ListaEmpregados[i].SalarioNovo(porcentagem);
        break;
    }
    else if (i > n)
    {
        Console.WriteLine("This id does not exist!");
    }
}
Console.WriteLine("Updated list of employees:");

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Employee #{i + 1}");
    Console.WriteLine(ListaEmpregados[i].ToString());
}
*/
// Exercicio resolvido matrizes
/*
int n = int.Parse(Console.ReadLine()), contador = 0;
int[,] caixa = new int[n,n];

for (int i = 0; i < n; i++)
{
    string[] box = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        caixa[i,j] = int.Parse(box[j]);
        if (caixa[i,j] < 0)
        {
            contador++;
        }
    }
}
Console.WriteLine("Main diagonal:");
for  (int i = 0;i < n; i++)
{
    Console.Write(caixa[i,i] + " ");
}
Console.WriteLine($"\nNegative Numbers = {contador}");
*/
// Exericicio de fixação matrizes
/*
3 4
10 8 15 12
21 11 23 8
14 5 13 19
8
Position 0,1:
Left: 10
Right: 15
Down: 11
Position 1,3:
Left: 23
Up: 12
Down: 19

string[] box1 = Console.ReadLine().Split(" ");
int num1 = int.Parse(box1[0]), num2 = int.Parse(box1[1]);
int[,] caixa = new int[num1, num2];
for (int i = 0; i < num1; i++)
{
    string[] box2 = Console.ReadLine().Split(" ");
    for (int j = 0; j < num2; j++)
    {
        caixa[i, j] = int.Parse(box2[j]);
    }
}
int numBuscado = int.Parse(Console.ReadLine());
for (int i = 0;i < num1; i++)
{
    for (int j = 0;j < num2; j++)
    {
        if (numBuscado == caixa[i, j])
        {
            Console.WriteLine($"Position {i},{j}:");
            if (j >= 0)        { Console.WriteLine($"Left: {caixa[i, j - 1]}"); }
            if (j < num2 -1)  { Console.WriteLine($"Right: {caixa[i,j + 1]}"); }
            if (i -1 >= 0)     { Console.WriteLine($"Up: {caixa[i - 1, j]}"); }
            if (i + 1 < num1) { Console.WriteLine($"Down: {caixa[i + 1,j]}"); }
        }
    }
}
*/
// Exepressão ternaria - exemplo abaixo!
/*
double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture), desconto;
// Uma expressão ternaria e como se fosse um if e else mas usando dentro de uma variavel que no caso e desconto
// if (preco < 20.00) { desconto = preco * 0.1; }
// else { desconto = preco * 0.05; }
// Exemplo da expressão ternaria abaixo
desconto = (preco < 20) ? preco *  0.1 : preco * 0.05; // Essa a expressão completa

Console.WriteLine(desconto);
 */
// Modulo de DateTime
// DateTime permite que voce possa pegar o horario atal ou usar um construtores
/* Builders e construtores do DateTime
Construtores:
    - DateTime(ano, mes, dia)
    - DateTime(ano, mes, dia, hora, minuto, segundo) [opcional:kind] -> kind seria cultureinfo.invariantculture ou cultureinfo.variantculture!
    - DateTime(ano, mes, dia, hora, minuto, segundo, milisegundo) [opcional:kind]
Builders:
    + DateTime.Now
    + DateTime.UtcNow
    + DateTime.Today [time: 00:00:00]
    + DateTime.Parse(string)
    + DateTime.ParseExact(string,string)
 */
/* 

DateTime d1 = new DateTime(2018, 11, 25);                 // construtor normal
DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);      // construtor com hora, minutos e segundos
DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // construtor com milisegundos

DateTime d4 = DateTime.Now;    // Ver a data e horario atual
DateTime d5 = DateTime.Today;  // Pega o horario de hoje
DateTime d6 = DateTime.UtcNow; // Pega o horario do UTC no horario universal GMT

DateTime d7 = DateTime.Parse("2000-08-15"); // O parse aceita varios padroes de formatos como [0000-00-00 00:00:00] (nota:ano vem primeiro depois mes e depois dia nesse horario)
DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d9 = DateTime.Parse("15/08/2000"); // [00/00/0000 00:00:00] (nota:horario normal bresileiro)
DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-mm-dd",CultureInfo.InvariantCulture); // ParseExact mexe mais com a formatação formatando a data e horario
DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

Console.WriteLine($"d1 Construtor normal:{d1}"); 
Console.WriteLine($"d2 Construtor com hora:{d2}");
Console.WriteLine($"d3 Construtor com milisegundos:{d3}\n");

Console.WriteLine($"d4 Builder Now:{d4} - Ticks do d4:{d4.Ticks}"); // mostra o horario e data atual e a quantidade de ticks (100 nano segundos) que passaram do dia 1
                                                                    // de janeiro ate a data atual essa e a forma bruta do d1!
Console.WriteLine($"d5 Builer Today:{d5}");     // Builder do Today
Console.WriteLine($"d6 Builder UtcNow:{d6}\n"); // Builder UtcNow

Console.WriteLine($"d7 Builder Tipo Parse:{d7}");  // Builder do Parse tipo (0000-00-00)
Console.WriteLine($"d8 Builder Tipo Parse:{d8}");  // Builder do Parse tipo (0000-00-00 00:00:00)
Console.WriteLine($"d9 Builder Tipo Parse:{d9}");  // Builder do Parse tipo (00/00/0000)
Console.WriteLine($"d10 Builder Tipo Parse:{d10}");// Builder do Parse tipo (00/00/0000 00:00:00) 
Console.WriteLine($"d11 Builder Tipo ParseExact:{d11}"); // Builder do ParseExact tipo (0000-00-00)
Console.WriteLine($"d11 Builder Tipo ParseExact:{d12}"); // Builder do ParseExact tipo (00/00/0000 00:00:00)
*/
// TimeSpan funções Usado para calcular multas, juros e outras coisas!
/* 
TimeSpan t1 = new TimeSpan(); // da 00:00:00
TimeSpan t2 = new TimeSpan(900000000L); // da 00:01:30
TimeSpan t3 = new TimeSpan(2, 11, 21); // da 02:11:21
TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // da  1.02:11:21
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); // da 1.02:11:21.3210000

TimeSpan t6 = TimeSpan.FromDays(1.5); // Pega o horario de um dia e meio que seria 1.12:00:00
TimeSpan t7 = TimeSpan.FromHours(1.5); // Pega o horario de uma hora e meia oque seria 01:30:00
TimeSpan t8 = TimeSpan.FromMinutes(1.5); // pega o horario de um minuto e meio oque seria 00:01:30
TimeSpan t9 = TimeSpan.FromSeconds(1.5); // Pega o horario de um segundo e meio qoue seria 00:00:01.5000000
TimeSpan t10 = TimeSpan.FromMilliseconds(1); // Pega o horario de um milisegundo oque seria 00:00:00.0010000
TimeSpan ticks11 = TimeSpan.FromTicks(900000000L); // Pega o horario em ticks oque deveria ser 00:01:30

Console.WriteLine($"t1 :{t1}");
Console.WriteLine($"t2 :{t2}");
Console.WriteLine($"t3 :{t3}");
Console.WriteLine($"t4 :{t4}");
Console.WriteLine($"t5 :{t5}");

Console.WriteLine($"t6 :{t6}");
Console.WriteLine($"t7 :{t7}");
Console.WriteLine($"t8 :{t8}");
Console.WriteLine($"t9 :{t9}");
Console.WriteLine($"t10 :{t10}");
Console.WriteLine($"ticks11 :{ticks11}");
*/
/* Propiedadas do DateTime e Time Span!!
DateTime:
 - Date(DateTime)
 - Day(int)
 - DayOfWeek(DayOfWeek)
 - DayOfYear(int)
 - Hour(int)
 - Kind(DateTimeKind)
 - Milisecond(int)
 - Minute(int)
 - Month(int)
 - Second(int)
 - Ticks(long)
 - TimeOfDay(TimeSpan)
 - Year(int)
TimeSpan:
 - MaxValue
 - MinValue
 - Zero     
 - Days     
 - Hours    
 - Minutes 
 - Miliseconds
 - Seconds 
 - Ticks 
 - TotalDays 
 - TotalHours 
 - TotalMinutes 
 - TotalSeconds
 - TotalMiliseconds
 */
// Exemplos abaixo
/* 
DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
TimeSpan t = new TimeSpan(2,3,5,7,11),t2 = TimeSpan.MaxValue,t3 = TimeSpan.MinValue,t4 = TimeSpan.Zero;
string s1 = d.ToLongDateString(), s2 = d.ToLongTimeString(), s3 = d.ToShortDateString(), s4 = d.ToShortTimeString(), s5 = d.ToString(), s6 = d.ToString("yyyy-MM-dd HH:mm:ss"), s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

Console.WriteLine($"""
    DateTime:
    EXEMPLO DE PROPRIEDADES
        {d}
        1) Date: {d.Date}
        2) Day: {d.Day}
        3) DayOfWeek: {d.DayOfWeek}
        4) DayOfYear: {d.DayOfYear}
        5) Hour: {d.Hour}
        6) Kind: {d.Kind}
        7) Milisecond: {d.Millisecond}
        8) Minute: {d.Minute}
        9) Month: {d.Month}
        10) Second: {d.Second}
        11) Ticks: {d.Ticks}
        12) TimeOfDay: {d.TimeOfDay}
        13) Year: {d.Year}
    EXEMPLO  DE FORMTAÇÃO
        ToLongDateString()   -> {s1}
        ToLongTimeString()   -> {s2}
        ToShortDateString()  -> {s3}
        ToShortTimeString()  -> {s4}
        ToString()           -> {s5}
        ToString(Sobrecarga) -> {s6}
        ToString(Sobre,mili) -> {s7}
    
    TimeSpan:
    EXEMPLO DE PROPIEDADES
    {t}
    1) MaxValue : {t2}
    2) MinValue : {t3}
    3) Zero     : {t4}
    4) Days     : {t.Days}
    5) Hours    : {t.Hours}
    6) Minutes  : {t.Minutes}
    7) Miliseconds: {t.Milliseconds}
    8) Seconds : {t.Seconds}
    9) Ticks : {t.Ticks}
    10) TotalDays : {t.TotalDays}
    11) TotalHours : {t.TotalHours}
    12) TotalMinutes : {t.TotalMinutes}
    13) TotalSeconds: {t.TotalSeconds}
    14) TotalMiliseconds: {t.TotalMilliseconds}
    """);
*/
// DateTime Operações possiveis!
/* 
DateTime data1 = new DateTime(2001, 8, 15, 13, 45, 58), data2 = new DateTime(2000, 10, 18);
DateTime d2 = data1.AddHours(2), d3 = data1.AddMinutes(3), d4 = data1.AddDays(7);
TimeSpan t = data2.Subtract(data1);

Console.WriteLine($"""
    variavel - d    : {data1}
    DateTime - AddHours(2)   : {d2}
    DateTime - AddMinutes(3) : {d3}
    DateTime - AddDays(7)    : {d4}
    TimeSpan - Subtract      : {t}
    """);
*/
// TimeSpan Operações possiveis!
/* 
TimeSpan t1 = new TimeSpan(1, 30, 10), t2 = new TimeSpan(0, 10, 5);
TimeSpan sum = t1.Add(t2), dif = t1.Subtract(t2), mult = t2.Multiply(2.0), div = t2.Divide(2.0);

Console.WriteLine($"""
    Sum  t1 + t2  : {sum}
    dif  t1 - t2  : {dif}
    mult t2 * 2.0 : {mult}
    div  t2 / 2.0 : {div}
    """);
*/
// DateTimeKind abaixo
/* 
DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local), d2 = new DateTime(2000,8,15,13,5,58, DateTimeKind.Utc),d3 = new DateTime(2000,8,15,13,5,58);
Console.WriteLine($"""
    d1: {d1}
    d1 Kind: {d1.Kind}
    d1 to Local {d1.ToLocalTime()}
    d1 to Utc {d1.ToUniversalTime()}
    
    d2: {d2}
    d2 Kind: {d2.Kind}
    d2 to Local {d2.ToLocalTime()}
    d2 to Utc {d2.ToUniversalTime()}

    d3: {d3}
    d3 Kind: {d3.Kind}
    d3 to Local {d3.ToLocalTime()}
    d3 to Utc {d3.ToUniversalTime()}
    """);
*/
// padrao ISO 8691 abaixo
/*
DateTime d1 = DateTime.Parse("2000-08-15 13:05:58"); // Data normal
DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");// Padrão ISO 8691

Console.WriteLine($"""
    d1: {d1}
    d1 Kind: {d1.Kind}
    d1 to Local: {d1.ToLocalTime()}
    d1 to Utc: {d1.ToLocalTime()}

    d2: {d2}
    d2 Kind: {d2.Kind}
    d2 to Local: {d2.ToLocalTime()}
    d2 to Utc: {d2.ToUniversalTime()}

    {d2.ToString("yyyy-MM-ddTHH:mm:ssZZ")} <- Tome cuidado!
    {d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")} <- Jeito correto! 

    """);
*/
// Capitulo de Enumerações e composição!
/* Explicação para Enumerações!
   E um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas!
   
    Ele e um tipo de valor que no CSharp se escreve como: enum

Exemplo

class Order                                     | enum OrderStatus : int 
{                                               | {
    public int Id { get; set; }                 |   PendingPayment = 0,
    public DateTime Moment { get; set; }        |   Processing = 1,
    public OrderStatus Status { get; set;}      |   Shipped = 2,
                                                |   Delivered = 3
}                                               | } 
*/
/*
 Exemplo Abaixo!!!
 
OrderExemplo request = new OrderExemplo
{
    Id = 1800,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(request);

string txt = OrderStatus.PendingPayment.ToString();
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine($"txt mostra o nome da enmuração {txt}\nja usando o Enum.Parse<>() ele mostra o delivered:{os}");
*/
// Exercicio Resolvido Enumeração - 01 
/* 
 Enter department's name: Design
 Enter worker data:
 Name: Alex
 Level (Junior/MidLevel/Senior): MidLevel
 Base salary: 1200.00
 How many contracts to this worker? 3
 Enter #1 contract data:
 Date (DD/MM/YYYY): 20/08/2018
 Value per hour: 50.00
 Duration (hours): 20
 
 Enter #2 contract data:
 Date (DD/MM/YYYY): 13/06/2018
 Value per hour: 30.00
 Duration (hours): 18
 
 Enter #3 contract data:
 Date (DD/MM/YYYY): 25/08/2018
 Value per hour: 80.00
 Duration (hours): 10
 
 Enter month and year to calculate income (MM/YYYY): 08/2018
 Name: Alex
 Department: Design
 Income for 08/2018: 3000.00
 */
/*
Console.Write("Enter deparment's name: ");
string nameDepart = Console.ReadLine();
Departaments depat = new Departaments(nameDepart);
Console.WriteLine("Enter Worker data:");
Console.Write("Name: ");
string nameWorker = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior) :");
WorkerLevel levelWorker = WorkerLevel.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base Salary:");
double salaryBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

WorkerDepartment worker = new WorkerDepartment(depat, nameWorker, levelWorker, salaryBase);

Console.Write("How many contracts to this worker? ");
int contractNumber = int.Parse(Console.ReadLine());
for (int i = 1; i <= contractNumber; i++)
{
    Console.Write($"\nEnter #{i} contract data:\nDate (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write($"Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write($"Duration (hours): ");
    int duration = int.Parse(Console.ReadLine());

    HourContract contractFor = new HourContract(date,valuePerHour,duration);
    worker.addContract(contractFor);
}

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string dateIncome = Console.ReadLine();
int month = int.Parse(dateIncome.Substring(0,2)), year = int.Parse(dateIncome.Substring(3));
Console.WriteLine($"""
				Name: {worker.Name}
				Department: {worker.Department.Name}
				income for {dateIncome}: {worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture)}
				""");
*/
// Exercicio Resolvido Demo String Builder - 02
/* 
Travelling to new zealand
12 likes - 21/06/2018 13:05:44
I'm going to visit thiis wonderful country!
Comments:
Have a nice trip
Wow that's awesome!

Good night guys
5 likes - 28/07/2018 23:14:19
See you tomorrow
Comments:
Good night
May the force be with you
 */
/* 
Comments c1Post1 = new Comments("Have a nice trip!"), c2Post1 = new Comments("Wow that's awesome!"),c1Post2 = new Comments("Good Night"), c2Post2 = new Comments("May the force be with you");
Post p1 = new Post("Traveling to new Zealand","I'm going to visit this wonderful country!",DateTime.Parse("21/06/2018 13:05:44"),12);
p1.AddComment(c1Post1);
p1.AddComment(c2Post1);

Post p2 = new Post("Good night guys","See you tomorrow",DateTime.Parse("28/07/2018 23:14:19"),5);
p2.AddComment(c1Post2);
p2.AddComment(c2Post2);

Console.WriteLine(p1+"\n"+p2);
*/
// Exercicio Proposto Cliente registrado!
/* 
Enter client data:
Name: Alex Green
Email: alex@gmail.com
Birth Date (DD/MM/YYYY): 15/03/1995
Enter order data: 20/04/2018 11:25:09
Status: Processing
How many items to this order? 2
Enter #1 item data:
Product name: TV
Product price: 1000.00
quantity: 1
Enter #2 item data:
Product name: Mouse
Product price: 40.00
Quantity: 2

ORDER SUMMARY:
Order moment: 20/04/2018 11:25:09
Order status: Processing
Client: Alex Green (15/03/1985) - alex@gmail.com
Order items:
tv, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse,$40.00, Quantiy: 2, Subtotal: $80.00
Total price: $1080.00

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string emailClient = Console.ReadLine();
Console.Write("Birth Date (DD/MM/YYYY):");
DateTime dateBirthClient = DateTime.Parse(Console.ReadLine());
Console.Write("Enter order data: (DD/MM/YYYY HH:MM:SS): ");
DateTime orderData = DateTime.Parse(Console.ReadLine());
Console.Write("Status: ");
OrderStatus orderStats = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(clientName,emailClient,dateBirthClient);
Order orderRequest = new Order(orderData, orderStats, client);

Console.Write("How many items to this order? ");
int op32 = int.Parse(Console.ReadLine());

for (int i = 1; i <= op32; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName,productPrice);
    OrderItem orderItem = new OrderItem(productQuantity,product);

    orderRequest.addItem(orderItem);
}

Console.WriteLine(orderRequest.ToString());
*/
// Modulo Herança e polimorfismo!
/* 
Heranças de uma classe podem ser um recurso valioso porque e reutilizavel. Em si a herança consegue passar não so suas funções mas suas variaveis permintindo que a classe filha possa herdar tudo.
Mas se a algum metodo ou variavel da classe mãe estar com o metodo private, a classe filha não podera herdar o metodo ou variavel mas se for protected a classe filha pode sim usar e puxar as variaveis
sem que o programa de fora consiga reatribuir o valor da variavel como a de um saldo em um banco oque seria perigoso!  

 Exemplo de herança!
Classe:                                                             | Herdado da classe:
class Account                                                       | class BusinessAccount : Account // Quando queremos herdar precisamos usar os dois pontos e depois o nome da classe!
{                                                                   | {
    public int Number { get; set; }                                 |       public double LoanLimit { get; set; } 
    public string Holder { get; set; }                              |       
    protected double balance {get; set; }                           |       public BusinessAccount() {} // Esse base() funciona como um reaproveitamento do construtor de Account para usar aqui! 
                                                                    |       public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number,holder,balance)
    public Account() { }                                            |       {
    public Account(int number, string holder, double balance)       |           LoanLimit = loanLimit;
    {                                                               |       }  
        Number = number;                                            |       public void Loan(double ammount)       
        Holder = holder;                                            |       {
        Balance = balance;                                          |          if (ammount <= LoanLimit) { Balance += ammount; }
    }                                                               |       }
}                                                                   | }
  */
// Upcasting & Downcasting
/* 
 Upcasting                                      | Downcasting
    - Casting da subclasse para superfice       |   - Casting da superclasse para subclasse
    - Uso comum: polimorfismo                   |   - Palavra as
                                                |   - Palavra is
                                                |   - Uso comum: métodos que recebem parametros genericos (ex:equals)
                                              
Usando as classes Account01, BusinessAccount01 e SavingAccount01 para o exemplo abaixo

Account01 acc = new Account01(1001, "Alex",0.0m);
BusinessAccount01 bacc = new BusinessAccount01(1002,"Maria", 0.0m, 500.0m);
// Exemplo de UpCasting

Account01 acc1 = bacc; // Devido o bacc ser naturalmente um account faz com que o Account receba naturalmente sua herança como atribuição
Account01 acc2 = new BusinessAccount01(1003, "Bob", 0.0m, 200.0m); // E possivel tambem usar o contrustor de uma herança com o propostio de atribuir
Account01 acc3 = new SavingAccount01(1004, "Maria", 0.0m, 0.01m); // Account e considerada uma superclasse e SavingAccount e uma subclasse então e possivel usar esse metodo
// Exemplo de DownCasting (Insegura) Nota: so pode usar quando realmente for necessario pois ha limitações!

BusinessAccount01 acc4 = (BusinessAccount01)acc2; // Aqui como acc2 e um Account mesmo usando um BusinessAccount como seu construtor acc4 nao vai reconhecer sem usar o DownCasting para funcionar!
acc4.Loan(100.0m); // Acc4 pode usar o metodo Loan porque e da propria BusinessAccount ja acc2 não pode porque e um tipo Account
// BusinessAccount01 acc5 = (BusinessAccount01)acc3; // Aqui o não funcionaria mesmo que o compilador mostre que esta correto! pois acc3 usa SavingAccount e não BusinessAccount

// Um metodo Para prever isso seria usando is no if exemplo abaixo:
if (acc3 is BusinessAccount01) // Vai falhar porque acc3 não e uma instancia de BusinessAccount
{ 
    // BusinessAccount01 acc5 = (BusinessAccount01)acc3; // Aqui seria uma falha igual em cima
    BusinessAccount01 acc5 = acc3 as BusinessAccount01; // Por causa do as e possivel instanciar o acc3 mesmo sendo diferente no BusinessAccount
    acc5.Loan(200.0m);
    Console.WriteLine("Loan!");
} 
if (acc3 is SavingAccount01)
{
    // SavingAccount01 acc5 = (SavingAccount01)acc3; // Daria certo aqui mas como o exemplo de cima e so para demonstração!
    SavingAccount01 acc5 = acc3 as SavingAccount01;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}
 */
// Sobreposição, palavras virtual, override & base
/* 
 Sobreposição ou Sobrescrita é a implementação de um metodo de uma superclasse na subclasse 
 para que um metodo comum(não abstrato) possa ser sobreposto, deve ser incluido nele o prefixo "virtual"

 Ao sobrescrever um metodo, devemos incluir nele o prefixo "override"
 Nota: Ja usamos a palavra base em construtores de subclasses!
 Exemplo abaixo:
 
Account01 acc1 = new Account01(1001, "Alex", 500.0m);
Account01 acc2 = new SavingAccount01(1002, "Anna", 500.0m, 0.01m);

acc1.Withdraw(10.0m); // Porque temos uma taxa ira tirar 15 do balanço  da conta! Porque a classe esta marcada com virtual significa que subclasses possam usar um override!
acc2.Withdraw(10.0m); // Porque o override esta na SavingAccount sem a taxa ira tirar apenas os 10! mas em outro exemplo podemos usar o override para descontar mais com uma taxa adcional!

Console.WriteLine($"Acc1:{acc1.Balance}, acc2:{acc2.Balance}"); 
*/
// Classes & metodos Selados!
/* 
 Suponha que voce queira evitar que sejam criados subclasses de SavingAccount para isso basta usar o sealed aonde ficaria public ou private 
 Nota: Metodos com override podem ser usar o sealed para impedir um novo override em outra subclasse da subclasse

Porque usar? pois garante performance ou segurança!
 */
/* Exercicio 01 RESOLVIDO DE POLIMORFISMO
Uma empresa possui funcionarios proprios e terceirizados. Para cada funcionario, deseja-se registrar nome, horas trabalhadas e valor por hora. 
Funcionarios terceirizados possuem ainda uma despesa adicional.

O pagamento dos funcionarios corresponde ao valor da hora multipicado pelas horas trabalhadas, sendo que os funcionarios terceirizados pelas horas trabalhadas 
sendo que os funcionarios terceirizados ainda recebem um bonus correspondente a 110% de sua despesa adicional.

Fazer um programa para ler os dados de N funcionarios (N fornecido pelo usuario) e armazena-los em uma lista depois de ler
todos os dados, mostrar nome e pagamento de cada funcionario na mesma ordem em que foram digitados.

Construa o programa conforme projeto ao lado. Veja exemplo na proxima pagina.

Exemplo:
Enter the number of employees: 3
Employee #1 data:
Outsourced (y/n)? n
name: Alex
Hours: 50
Value per hour: 20.00
Employee #2 data:
Outsourced (y/n)? y
Name: Bob
Hours: 100
Value per hour: 15.00
Additional charge: 200.00
Employee #3 data:
Outsourced (y/n)? n
Name: Maria
Hours: 60
Value per hour: 20.00

Payments:
Alex - $ 1000.00
Bob - $ 1720.00
Maria - $ 1200.00
 */
/*
List<Employee> employees = new List<Employee>();
Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsourced (y/n)? ");
    char optionSourced = char.Parse(Console.ReadLine());
	Console.Write("Name: ");
	string nameEmployee = Console.ReadLine();
	Console.Write("Hours: ");
	int hourEmployee = int.Parse(Console.ReadLine());
	Console.Write("Value per hour: ");
	decimal valueHourEmployee = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
	if (optionSourced == 'y')
	{
		Console.Write("Additional charge: ");
		decimal additionalCharge = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		employees.Add(new OutsourcedEmployee(nameEmployee, hourEmployee, valueHourEmployee, additionalCharge));
	}
	else
	{
		employees.Add(new Employee(nameEmployee, hourEmployee, valueHourEmployee));
	}
}
Console.WriteLine("Payments:");
foreach  (Employee employee in employees)
{
    Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2",CultureInfo.InvariantCulture)}");
}
*/
/* Exercicio de Fixação (herança e polimorfismo)
Enter the number of products: 3
Product #1 data:
Common, used or imported (c/u/i)? i
Name: Tablet
Price: 260.00
Custom fee: 20.00
Product #2 data:
Common, used or imported (c/u/i)? c
Name: notebook
Price: 1100.00
Product #3 data:
Common, used or imported (c/u/i)? u
Name: Iphone
Price: 400.00
Manufacture date (DD/MM/YYYY): 15/03/2017

PRICE TAGS:
Tablet $280.00 (Customs fee: $ 20.00)
Notebook $ 1100.00 
Iphone (used) $ 400.00 (Manufacture date: 15/03/2017)
 
List<ProductFixHeriPoly> productFix = new List<ProductFixHeriPoly>();
Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
	Console.WriteLine($"Product #{i} data:");
	Console.Write("Common, used or imported (c/u/i)? ");
	char optionSourced = char.Parse(Console.ReadLine());
	Console.Write("Name: ");
	string nameProduct = Console.ReadLine();
	Console.Write("Price: ");
	decimal priceProduct = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
	if (char.ToLower(optionSourced) == 'i')
	{
		Console.Write("Custom fee: ");
		decimal customFeeProduct = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		productFix.Add(new ImportedProduct(nameProduct, priceProduct, customFeeProduct));
	}
	else if (char.ToLower(optionSourced) == 'u')
	{
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        string manufactureDate = Console.ReadLine();

		productFix.Add(new UsedProduct(nameProduct, priceProduct, manufactureDate));
	}
    else
    {
        productFix.Add(new ProductFixHeriPoly(nameProduct,priceProduct));
    }
}
Console.WriteLine("PRICE TAGS:");
foreach (ProductFixHeriPoly productfix in productFix)
{
    Console.WriteLine(productfix.priceTag());
}
 */
// Classes Abstratas
/*
 São classes que não odem ser instanciadas. É uma forma de garantir herança total: somente subclasses não abstatras 
 podem ser intanciadas mas nunca a superclasse abstrata
 
Exemplo:

Suponha que em um negocico relacionado a banco, apenas contas poupança e contas para empresas são permitidas. Não existe conta comum

Para garantir que contas comuns não possam ser instanciadas, bata acrescentarmos a palavra "abstract" na declaração da classe

Nota: Existe duas classes que herdam da Account que são SavingAccount e BusinessAccount!
Namespace Course {
    abstract class Account { }
    
}

Quenstionamento

    - Se a classe Account não pdoe ser instanciada porque simplesmente não criar somente SavingsAccount e BusinessAccoount 
      Resposta: Reuso e Polimorfismo a superclasse classe generica nos permite tratar de forma facil e uniforme todos os tipos de conta inclusive com polimorfismo se for o caso
                (Como foi feito nos ultimos exercicios). Por exemplo, você pode colocar todos tipos de contas em uma mesma coleção 

Demo abaixo: Suponha que voce queira totalizar o saldo de todas as contas. Sacar 10.00 de todas as contas

List<Account> list = new List<Account>(); // Se a classe account não existe-se não poderiamos mistrurar varias classes mas como ela e uma 
                                         // Superclasse generica ela pode sim usar

list.Add(new SavingsAccount(1001,"Alex", 500.0, 0.01);
list.Add(new SavingsAccount(1002,"Maria", 500.0, 400.0);
list.Add(new SavingsAccount(1003,"Bob", 500.0, 0.01);
list.Add(new SavingsAccount(1001,"Anna", 500.0, 500.0);

decimal sum = 0.0m;
foreach (Account acc in list)
{
    sum += acc.Balance;
}

Console.WriteLine($"Total balance: {sum.ToString("F2",CultureInfo.InvariantCulture)}");

foreach (Account acc in list)
{
    acc.Withdraw(10.0);
}
foreach (Account acc in list)
{
    Console.WriteLine($""" 
    Updated balance for account:
    {acc.Number} : {acc.Balance.ToString("F2",CultureInfo.InvariantCulture)}
""");
}

*/
// Exercicio Resolvido 01 (Metodos Abstratos)
/* 
 Fazer um programa para ler os dados de N figuras (N fornecido pelo usuario),e 
depois mostrar as areas destas figuras na mesma ordem em que foram digitadas.

Enter the number of the shapes: 2
Shape #1 data:
Rectangle or cicle (r/c)? r
Color (Black/Blue/Red): Black
Width: 4.0
Height: 5.0
Shape #2 data:
Rectangle or Circle (r/c)? c
Color (Black/Blue/Red): Red
Radius: 3.0

SHAPES AREAS:
20.00
28.27

List<Shape> Shapes = new List<Shape>();
Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
	Console.WriteLine($"Shape #{i} data:");
	Console.Write("Rectangle or Cricle (r/c)? ");
	char optionSourced = char.Parse(Console.ReadLine());
	Console.Write("Color (Black/Blue/Red): ");
	Color colorOption = Color.Parse<Color>(Console.ReadLine());
	if (char.ToLower(optionSourced) == 'r')
	{
		Console.Write("Width: ");
		double widthRectangle = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
		Console.Write("Height: ");
		double heigthRectangle = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
	    Shapes.Add(new Rectangle(colorOption, widthRectangle, heigthRectangle));
	}
	else if (char.ToLower(optionSourced) == 'c')
	{
		Console.Write("Radius: ");
		double radiushRectangle = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		Shapes.Add(new Circle(colorOption, radiushRectangle));
	}
}
Console.WriteLine("SHAPES AREAS:");
foreach (Shape shapes in Shapes)
{
	Console.WriteLine(shapes.Area().ToString("F2",CultureInfo.InvariantCulture));
}
 */
// Exercicio Resolvido 02 (Metodos Abstratos)
/* 
Nota: abaixo de 20000.00 so paga 15% e acima paga 25%, se a pessoa tiver gastos com saude 50% dos gastos sao abatidos no imposto, Ja uma empresa 
      paga 16% de imposto porem se a empresa possuir mais de 10 funcionarios, ela paga 14% de imposto.

Enter the number of tax payer: 3
Tax payer #1 data:
Individual or company (i/c)? i
Name: Alex
Anual income: 50000.00
Health expenditures: 2000.00
Tax payer #2 data:
Individual or company (i/c)? c
Name: SoftTech
Anual Income: 400000.00
Number of employees: 25
Tax payer #3 data:
Individual or company (i/c)? i
Name: Bob
Anual Income: 120000.00
Health expenditures: 1000.00

TAXES PAID:
Alex: $ 11500.00
SoftTech: $ 56000.00
Bob: $ 29500.00

TOTAL TAXES: $ 97000.00

List<TaxPayer> Taxes = new List<TaxPayer>();
Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
	Console.WriteLine($"Tax payer #{i} data:");
	Console.Write("Individual or Company (i/c)? ");
	char optionSourced = char.Parse(Console.ReadLine());
	Console.Write("Name: ");
	string nameTax = Console.ReadLine();
	Console.Write("Anual Income: ");
	decimal anualIncome = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
	if (char.ToLower(optionSourced) == 'i')
	{
		Console.Write("Health Expenditures: ");
		decimal healthExpenditures = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		Taxes.Add(new Individual(nameTax, anualIncome, healthExpenditures));
	}
	else if (char.ToLower(optionSourced) == 'c')
	{
		Console.Write("Number of employees: ");
		int numberOfEmployees = int.Parse(Console.ReadLine());
		Taxes.Add(new CompanyTax(nameTax, anualIncome, numberOfEmployees));
	}
}
Console.WriteLine("TAXES PAID:");
decimal sum = 0.0m;
foreach (TaxPayer taxes in Taxes)
{
    sum += taxes.Tax();
	Console.WriteLine($"{taxes.Name}: $ {taxes.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
}

Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
 */
// Discussão incial sobre exceções
/* Estrutura Execeção, Try-Catch
Uma execeção e qualquer condição de erro ou comportamento inesperado encontrado por um programa em execeção, no .NET, uma execeção e um objeto herdado na classe System.Exception
Quando lançada, uma excecção, ate que seja capturada (tratada) ou o programa seja encerrado

Por que exceções?
Resposta: O modelo de tratamento de exceções permite que erros sejam cometidos tratados de forma consistente e flexivel, usando boas praticas.

Vantagens de usar exceções:
    ° Delega a logica do erro para a classe ou metodo responsavel por conhecer as regras que podem ocasionar o erro
    ° Trata de forma organizada (inclusive hierarquica) execeções de tipos diferentes
    ° A execeção pode carregar  dados quaisquer

Metodos e subclasses que a classe exception tem:
Exception 
    - System Exception
        * IndexOutOfRangeException
        * NullReferenceException
        * InvalidCastExpansion
        * OutOfMemoryException
        + ArgumentException
            * ArgumentNullException
            * ArgumentOutOfRangeException
        + ExternalException 
            * ComException
            * SEHException
        + ArithmeticException
            * DivideByZeroException
            * OverFlowException
    - ApplicationException

Estruta try-catch
	- Bloco try
	* Contem o codigo que representa a exceção normal do trehco de codigo
	  pode acarretar em uma exceção
	
	- Bloco catch
	* Contem o codigo a ser executado caso uma exceção ocorra
	* Deve ser especificado o tipo da exceção a ser tratada (Upcasting e permtido)

Exemplo da Sintaxe:
    try {
    
    }
    catch (ExceptionType e) { 

    }
    catch (ExceptionType e) {
    
    }
    catch (ExceptionType e) {
    
    }

Exemplo de um codigo
    try {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int result = n1 / n2;
        Console.WriteLine(result);
    }
    catch (DivideByZeroException) { 
        Console.WriteLine($"Division by zero is not allowed");
    }
    catch (FormatException e) {
        Console.WriteLine($"Format error! {e}");
    }

Exemplo de um codigo com o bloco Finaly 
FileStream fs = null;
try {
	fs  = new FileStream(@"C:\temp\data.txt", FileMode.Open);
	StreamReader sr = new StreamReader(fs);
	string line = sr.ReadLine();
	Console.WriteLine(line);
    }
    catch (FileNotFoundException e) {
	Console.WriteLine(e.Message);
    }
    finaly { // Esta fechando o fs
	if (fs != null) {
		fs.Close();
	}
}


 */
// Criando exceções personalizadas PARTE 1
/* 
Problema exemplo 

Fazer um programa para ler os dados de uma reserva de hotel (numero do quarto, data de entrada e data de saida)
e mostrar os dados da reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saida, atualizar
a reserva, e mostrar novamente a reserva com os dados atualizados o programa não deve
aceitar dados invalidos para a reserva, conforme as seguintes regras:
- Alterações de reserva so podem ocorrer para datas futuras
- A data de saida deve ser maior que a data de entrada

Class Reservation
- roomNumber : integer
- checkIn : Date
- checkOut : Date

Methods:
+ duration(): Integer
+ updateDates(checkIn : Date, checkOut : Date) : void

Room number: 8021
Check-in date (dd/MM/yyyy):23/09/2019
Check-out date (dd/MM/yyyy): 26/09/2019
Reservation: Room 8021, check-in:23/09/2019 , check-out:26/09/2019, 3 nights

Enter data to update the reservation:
Check-in date (dd/MM/yyyy):24/09/2019
Check-out date (dd/MM/yyyy): 29/09/2019
Reservation: Room 8021, check-in:24/09/2019 , check-out:29/09/2019, 5 nights
 */
/*
try
{
    Reservation reservation = new Reservation();
    Console.Write("Room number:");
    int roomNumber = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy):");
    DateTime entryDate = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy):");
    DateTime leaveDate = DateTime.Parse(Console.ReadLine());
    if (entryDate <= leaveDate)
    {
        Console.WriteLine("Error in reservation: Check-out date must be after check-in date.");
    }
    else
    {
        reservation = new Reservation(roomNumber, entryDate, leaveDate);
        Console.WriteLine($"{reservation.ToString()}\n");

        Console.WriteLine("Enter data to update the reservation:");
        Console.Write("Check-in date (dd/MM/yyyy):");
        DateTime newEntryDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (dd/MM/yyyy):");
        DateTime newLeaveDate = DateTime.Parse(Console.ReadLine());

        reservation.UpdateDates(newEntryDate, newLeaveDate);

        Console.WriteLine(reservation.ToString());
    }
}
catch (DomainException e)
{
    Console.WriteLine($"Error in reservation {e.Message}");
}
*/
/* Exercicio de fixação Bloco try catch
 
Fazer um programa para ler os dadosde uma conta bancaria e depois realizar um saque
nesta conta bancaria, mostrando novo saldo. Um saque não pode ocorrer ou se não houver
salvo na conta, ou se o valor do saque foi superior ao limite de saque da conta. Implemente a conta bancaria conforme projeto abaixo:

Account
- number : Integer
- holder : String
- balance: Double
- withdrawLimit : Double
+ Methods
  + deposit(amount: Double) : void
  + withdraw(amount : Double) : void

exemplo de erro:
Enter account data
Number: 8021
Holder: Bob brown
Initial balance: 200.00
Withdraw limit: 300.00

Enter amount for withdraw: 250.00
Withdraw error: Not enough balance.

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number:");
    int numberAcc = int.Parse(Console.ReadLine());
    Console.Write("Holder:");
    string holderAcc = Console.ReadLine();
    Console.Write("Initial balance:");
    decimal inbalanceAcc = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit:");
    decimal withdrawLimitAcc = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    Account02 account = new Account02(numberAcc, holderAcc, inbalanceAcc, withdrawLimitAcc);
    Console.WriteLine(account.ToString());


    Console.Write("\nEnter amount for withdraw:");
    decimal amountAcc = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Withdraw(amountAcc);
    Console.WriteLine($"New balance:{account.Balance.ToString("F2",CultureInfo.InvariantCulture)}");

    
}
catch (BalanceException e)
{
    Console.WriteLine(e.Message);
}
*/
/* File ou FileInfo
Realiza operações com arquivos (create,copy,delete,move,open,etc.) e ajuda na criação
de objetos FileStream.

File -> simples apenas por membros estaticos, mas realiza verificação de 
segurança para cada operação.

FileInfo -> Pode ser instanciada!

Todas as exceções de IOException
- DirectoryNotFoundException
- DriveNotFoundException
- EndOfStreamException
- FileLoadException
- PathTooLongException
- PipeException

Sempre que for usar tem que botar Using System.Io

Exemplo abaixo:

string sourcePath = @"C:\Users\Gamer\Documents\file1.txt";
string targetPath = @"C:\Users\Gamer\Documents\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}

//Outro exemplo abaixo:

string sourcePath = @"C:\Users\SeuUsuario\Downloads\file1.txt";
string targetPath = @"C:\Users\SeuUsuario\Downloads\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath)

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
*/
/* FileStream e StreamReader
+ A FileStream disponibiliza uma stream associada a um arquivo, permitindo operações
  de leitura e escrita.

  Suporte a dados binários

  Instanciação:
   * Varios Construtores
   * File / FileInfo

+ StreamReader é uma stream capaz de ler caracteres a partir de uma stream binária 
  (ex: FileStream).

  Suporte a dados no formato de texto.

  Instanciação:
   * Varios Construtores
   * File / FileInfo

Exemplo abaixo

string path = @"C:\Users\Gamer\Documents\file1.txt";
FileStream fs = null;
StreamReader sr = null;

try
{
    fs = new FileStream(path, FileMode.Open);
    sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}
*/
/*Using block

Sintaxe simplificada que garante que os objetos IDisposable serão fechados.

Objetos IDisposiable NÃO são gerenciados pelo CLR. Eles precisam ser manualmente fechados
Exemplos: Font,FileStream,StreamReader, StreamWriter

Exemplo abaixo:

string path = @"C:\Users\Gamer\Documents\file1.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine($"An error has ocurred {e}");
}
*/
/* StreamWriter
É uma stream capaz de escrever caracteres a partir de uma stream binária (ex:FileStream).

Suporte a dados no formato de texto.

Instanciação:
 * Multiplos construtores
 * File / FileInfo
   * CreateText(path)
   * AppendText(String)

Exemplo abaixo:
string sourcePath = @"C:\Users\Gamer\Documents\file1.txt";
string targetPath = @"C:\Users\Gamer\Documents\file2.txt";

try 
{
	string[] lines = File.ReadAllLines(sourcePath);

	using (StreamWriter sw = File.AppendText(targetPath))
	{
		foreach(string line in lines)
		{
			sw.WriteLine(line.ToUpper());
		}
	}
}
catch (IOException e)
{
	Console.WriteLine($"An error occurred: {e}");
}
*/
/* Directory, DirectoryInfo

Operações com pastas (create, enumerate, get files, etc.).

Directory 
 * Static members(simple,but,performs security check for each operation) 
 * https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
DirectoryInfo
 * Instance members
 * https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx

Exemplo abaixo:
//Nota: Usar Using System.Collections.Generic

string path = @"C:\Users\Gamer\Documents\";

try
{
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders:");
    foreach (string s in folders)
    {
        Console.WriteLine(s);
    }
}
catch (IOException e)
{
    Console.WriteLine($"An error ocurred: {e.Message}");
}
*/
/* Path
Realiza operações com strings que contem informaçõesde arquivos ou pastas.

Exemplo:
string path = @"C:\Users\Gamer\Documents\file1.txt"

Console.WriteLine($"DirectorySerapartorChar:{Path.DirectorySerapartorChar}");
Console.WriteLine($"PathSerapartor:{Path.PathSeparator}");
Console.WriteLine($"GetDirectoryName:{Path.GetDirectoryName(path)}");
Console.WriteLine($"PathSerapartor:{Path.PathSeparator(path)}");
Console.WriteLine($"GetFileName:{Path.GetFileName(path)}");
Console.WriteLine($"GetExtension:{Path.GetExtension(path)}");
Console.WriteLine($"GetFileNameWithoutExtension:{Path.GetFileNameWithoutExtension(path)}");
Console.WriteLine($"GetFullPath:{Path.GetFullPath(path)}");
Console.WriteLine($"GetTempPath:{Path.GetTempPath(path)}");
*/
/* Exercicio proposto  caminhos
Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens
vendidos. Cada item possui um nome, preço unitario e quantidade, separados por 
vírgula. Você deve gerar um novo arquivo chamado "summary.csv",localizado em uma sub
pasta chamada "out" a partir da pasta original do arquivo de origem, contendo apenas
o nome e o valor total para aquele item (preço unitario multiplicado pela quantidade)
conforme exemplo.

Correção: https://github.com/acenelio/files1-csharp
Source file:			    | Output File:
TV LED, 1290.99,1		    | TV LED,1290.99
Video Game Chair,350.50,3	| Video Game Chair,1051.50
Iphone X,900.00,2		    | Iphone X,900.00,2
Samsung Galaxy 9,850.00,2	| Samsung Galaxy 9,850.00,2


Console.Write("Enter file full path: ");
string sourcePath = Console.ReadLine();

try
{
    string sourceFolderPath = Path.GetDirectoryName(sourcePath);
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetPath = targetFolderPath + @"\summary.csv";
    
    Directory.CreateDirectory(targetFolderPath);
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            string[] fields = line.Split(',');
            string name = fields[0];
            decimal value = decimal.Parse(fields[1],CultureInfo.InvariantCulture);
            int quantity = int.Parse(fields[2]);

            sw.WriteLine($"{name},{value * quantity}");
        }
    }
}
catch (IOException e)
{
    Console.WriteLine($"An error occurred: {e}");
}
*/
/*Interface

Interface é um tipo que define um conjunto de operações que uma classe (ou struct)
deve implementar.

A interface estabelece um contrato que a classe (ou struct) deve cumprir.

Pra quê interfaces
R: Para criar sistemas com baixo acoplamento e flexíveis

Exemplo:
interface IShape {
	
	double Area();
	double Perimeter();
}

Problema exemplo abaixo:
Uma locadora brasileira de carros cobra um valor por hora para locações de até 12 
hora. Porém, se a duração da locação ultrapassar 12 horas, a locação será cobrada
com base em um valor diário. Além do valor da locação,é acrescido no preço o valor
do imposto conforme regras do país que, no caso do brasil, é 20% para valores até
100.00, ou 15% para valores acima de 100.00 fazer um programa que lê os dados da 
locação  (modelo do carro, instante inicial e final da locação), bem como o valor
por hora e o valor diario de locação o programa deve então gerar a nota de pagamento
(contendo valor da locação, valor do imposto e total do pagamento) e informar os
dados na tela. Veja os exemplos 

Example 1:
Enter rental data
Car model:Civic
Pickup (dd/MM/yyyy hh:mm): 25/60/2018 10:30
Return (dd/MM/yyyy hh:mm): 25/06/2018 14:30
Enter price per hour: 10.00
Enter price per day: 130.00
INVOICE:
Basic payment: 50.00
Tax: 10.00
Total payment:60.00
- Calculations ex1:
Duration = (Pickup) - (Return) = 4:10 -> 5 hours
Basic payment = 5 * 10 = 50
Tax = 50 * 20% -> 5 * 0.2 = 10

Example 2:
Enter rental data
Car model:Civic
Pickup (dd/MM/yyyy hh:mm): 25/60/2018 10:30
Return (dd/MM/yyyy hh:mm): 27/06/2018 11:40
Enter price per hour: 10.00
Enter price per day: 130.00
INVOICE:
Basic payment: 390.00
Tax: 58.50
Total payment:448.50
- Calculations ex1:
Duration = (Pickup) - (Return) = 2 days + 1:10 -> 3 hours
Basic payment = 3 * 130 = 390

Tax = 390 * 15% -> 390 * 0.15 -> 58.50

Console.Write("Enter rental data\nCar model:");
string nameVehicle = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm):");
DateTime pickupVehicle = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:mm):");
DateTime ReturnVehicle = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double pricePerHour = double.Parse(Console.ReadLine(    ), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double pricePerDay = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(pickupVehicle, ReturnVehicle, new Vehicle(nameVehicle));

RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);
*/
/* Inversão de controle e injeção de dependência
- Acomplamento forte
- A classe Rental Service conhece a dependência concreta
- Se a classe concreta mudar é preciso mudar a classe RentalService

+------------------------------------------------+  	 +----------------------------------+
|                   Rental Service 		         |  	 |         BrazilTaxService         |
+------------------------------------------------+  	 +----------------------------------+
| + pricePerHour : Double			             | ====> | + tax(amount : Double) : Double) |
| + pricePerDay  : Double			             |	     +----------------------------------+
+------------------------------------------------+
| + processInvoice(carRental : CarRental) : Void |
+------------------------------------------------+

class RentalSerivce {

(...)

private BrazilTaxService _brazilTaxService = new BrazilTaxService();
 
}

*/
/* Exercicio de fixação 
Uma empresa deseja automatizar o processamento de seus contratos. o processamento de um contrato
consiste em gerar as parcelas a serem pagas para aquele contrato, com base no número de meses desejado.

A empresa ultiliza um serviço de pagamento online para realizar o pagamento das parcelas. Os serviços
de pagamento online tipicamente cobram um juro mensal, bem como uma taxa por pagamento. Por enquanto,
o serviço contratado pela empresa é o Paypal, que aplica juros simples de 1% a cada parcela, mais uma 
taxa de pagamento 2%

Fazer um programa  para ler os dados de um contrato (número do contrato, data do contrato, e valor total
do contrato). Em seguida, o programa deve ler o número de meses para parcelamento do contrato,´e daí gerar
os registros de parcelas a serem pagas (data e valor), sendo a priemria parcela a ser paga um mês após a data do contrato
a segunda parcela dois meses após o contrato e assim por diante. Mostrar os dados das parcelas na tela.

veja o exemplo abaixo:
Example:
Enter contract data
Number: 8028
Date (dd/MM/yyyy): 25/06/2018
Contract value:600.00
Enter number of installments: 3
Installments:
25/07/2018 - 206.04
25/08/2018 - 208.08
25/09/2018 - 210.12

Calculations (1% monthly simple interest + 2% payment fee):
Quota #1:	        | Quota #2: 		 | Quota #3:
200 * 1% * 1 = 202  | 200 * 1% * 2 = 204 | 200 * 1% * 3 = 206
202 + 2% = 206.04   | 204 + 2% = 208.08	 | 206 + 2% = 210.12



Console.Write("Enter contract data\nNumber:");
int numberContract = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy):");
DateTime DateContract = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value:");
double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments:");
int numberInstall = int.Parse(Console.ReadLine());

Contracts myContract = new Contracts(numberContract, DateContract, valueContract);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, numberInstall);

Console.WriteLine("Installments:");
foreach (Installment installment in myContract.Installments)
{
    Console.WriteLine(installment);
}
*/
/* Herança multipla e o problema do diamante
A herança multipla pode gerar o problema do diamante que é uma ambiguidade causada pela
existencia do mesmo metodo em mais de uma superclasse.
Herança multipla não são permitidas na maioria das linguages

exemplo
Scanner 			               | Printer
+ processDoc(doc : String) : void  | + processDoc(doc : String) : void
+ scan() : String 	 	           | + print(doc : String) : void

class ComboDevice : Scanner, Printer {} // Ira dar erro para previnir o problema do diamante

Porem uma classe ou struct pode implemantar mais de uma interface! oque resolve o problema

<<interface>>	  | <<interface>>	
Scanner		      | Printer
+ scan() : string | +print(doc : String) : void

sendo implementados para ComboDevice
ComboDevice
+ processDoc(doc : string) : void
+ scan() : String
+ print(doc : String) : void

comboDevice herda de Device

Device
- serialNumber : String
+ processDoc( doc : String) : void

ATENÇÃO! 
Isso não é herança multipla pois não há reuso na relação entre ComboDevice 
e as interfaces Scanner e Printer, ComboDevice não herda, mas sim implementa as
interfaces em outras palavras cumprindo o contrato.


Printer p = new Printer() { SerialNumber = 1080 };
p.ProcessDoc("My Letter");
p.Print("My letter");

Scanner s = new Scanner() { SerialNumber = 1090 };
s.ProcessDoc("My Email");
Console.WriteLine(s.Scan());

ComboDevice c = new ComboDevice() { SerialNumber = 2000};
c.ProcessDoc("My dissertation");
c.Print("My dissertation");
Console.WriteLine(c.Scan());
*/
/* Interface comparable 
exemplo pratico:
Faça um programa para ler um arquivo contendo nomes de pessoas (um por linha), armazenando os em uma lista.
Depois, ordenar os dados dessa lista e mostra-los ordenadamente na tela. Nota: o caminho do arquivo pode 
ser informado "hardcode".

Maria Brown
Alex Green
Bob grey
Anna White
Alex Black
Eduardo Rose
Marta Blue
Alex Brown


string path = @"c:\Users\Gamer\Downloads\in.txt";
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee12> list = new List<Employee12>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee12(sr.ReadLine()));
        }
        list.Sort();
        foreach (Employee12 emp12 in list)
        {
            Console.WriteLine(emp12.ToString());


        }
    }
}
catch (IOException e)
{
    Console.WriteLine($"An error as ocurred\n {e.Message}");
}
*/
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

Problema motivador 2 (Type safety & perfomance)
Deseja-se fazer um programa que leia um conjunto de N números inteiros (
N de 1 a 10) e depois imprime esses números de forma organizada conforme exemplo.
Em seguida, informar qual foi o primeiro valor informado.

Não usar Object como tipo para os metodos e variaveis isso deixa vulneravel a segurança de tipos(type safety), Então usaremos o tipo generics
que não permite manipular a variavel da clase com um outro tipo de variavel quando for instanciada

PrintService<int> ps = new PrintService<int>();
//PrintService<string> ps = new PrintService<string>();

Console.Write($"How many values? ");
int num = int.Parse(Console.ReadLine());

for  (int i = 0; i < num; i++)
{
    int x = int.Parse(Console.ReadLine());
    ps.addValue(x);
}

ps.print();
Console.WriteLine($"First:{ps.first()}");
 */
/* Problema nas restriçoes do generics

Uma empresa de consultoria deseja avaliar a perfomance de produtos, funcionários, dentro outras coisas. Um dois cálculos que ela 
que ela precisa é encontrar o maior dentr um conjunto de elementos. Fazer
um programa que leia um conjunto de N produtos, conforme exemplo, e depois mostre o mais
caro deles.

exemplo:
Enter N: 3				Criar um serviço de calculo
Computer, 890.50			CalculationService
Iphone X, 910.00			+ max<T>(list : List<T>):T
Tablet, 550.00
Most expensive;
Iphone X, 910.00

List<ProductComp> listPro = new List<ProductComp>();

Console.Write("Enter N:");
int Num = int.Parse(Console.ReadLine());    

for (int i = 0; i < Num; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    string name = vect[0];  
    double price = double.Parse(vect[1],CultureInfo.InvariantCulture);
    listPro.Add(new ProductComp(name, price)); 
}

CalculationService calcServ = new CalculationService();

ProductComp max = calcServ.Max(listPro);

Console.Write($"The most expesnive product is {max}");
*/
/* GetHashCode e Equals
 * São operações da classe Object utilizadas para comparar se um objeto é
   igual a outro
  
 * Equals: lento, reposta 100%
 * GetHashCode: rápido, porém resposta positiva não é 100%

 * Os tipos pré definidos ja possuem implementação para essas operações. Classes
   e structs personalizados precisam sobrepô-las.

- Equals:
  Método que compara se o objeto é igual a outro, retornando true ou false

  Exemplo
  
  string a = "Maria";
  string b = "Alex";
  string c = "Maria";

  Console.WriteLine(a.equals(b)); // Da Falso
  Console.WriteLine(a.equals(c)); // Da True

- GetHashCode:
  Método que retorna um número inteiro representado um código
  gerado a partir das informações do objeto
  
  Exemplo
  
  string a = "Maria";
  string b = "Alex";

  Console.WriteLine(a.GetHashCode()); // Da 1617898981
  Console.WriteLine(b.GetHashCode()); // Da 1617898981
Regra de ouro do GetHashCode
 * Se o codigo de dosi objetos for diferente, então os dois objetos são
   diferentes 

   Isso nunca acontece:
   "Alex Larry Brown" ----> -242670543 
   "Alex Larry Brown" ---->  880483901

 * Se o codigo de dois objetos for igual, muito provavelmente os objetos
   são iguais (pode haver colisão)

GetHashCode e Equals personalizados
 
Um exemplo abaixo

ClientCustom customCli_A = new ClientCustom { Name = "Maria", Email = "maria@gmail.com"};
ClientCustom customCli_B = new ClientCustom { Name = "Alex", Email = "alex@gmail.com" }; // Se for trocado para maria@gmail.com ira dar igual do ponto de vista do conteudo mas diferente do ponto
                                                                                         // de vista da memoria
Console.WriteLine(customCli_A.Equals(customCli_B));
Console.WriteLine(customCli_A == customCli_B);
Console.WriteLine($"HashCode A {customCli_A.GetHashCode()}");
Console.WriteLine($"HashCode B {customCli_B.GetHashCode()}");
*/
/* HashSet<T> e SortedSet<T>
Links:
HashSet -> https://msdn.microsoft.com/en-us/library/bb359438(v=vs.110).aspx
SortedSet -> https://msdn.microsoft.com/en-us/library/dd412070(v=vs.110).aspx



 Representa um conjunto de elementos (similiar ao da Álgebra)
  * Não admite repetições
  * Elementos não possuem posição  
  * Acesso, incersão e remoção de elementos são rapidos
  * Oferece operações eficientes de conjunto: interseção, união
    e diferença
Diferenças:
HashSet:
  * Armazenamento em tabela hash
  * Extremamente rápido: inserção, remoção e busca O(1)
  * A ordem dos elementos não é garantida
SortedSet:
  * Armazenmaneto em árvore
  * Rápido: inserção remoção e busca O(log(n))
  * Os elementos são armazenados ordenadamente conforme implementação
    IComparer<T>

Alguns metódos importantes
* Add
* Clear
* Contains
* UnionWith(other) - operação união: adiciona no conjunto os elementos do outro
  conjunto, sem repetição
* IntersectWith(Other) - operação interseção: remove do conjutno os elementos não contidos em other
* ExceptWith(other) - operçaão diferença: remove do conjunto os elementos contidos em other
* Remove(T)
* RemoveWhere(predicate)

Exemplo:
HashSet<string> set = new HashSet<string>();
set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Computer")); // False

foreach ( string p in set){
	Console.Writeline(p);
}

SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10};
SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10};

// union

SortedSet<int> c = new SortedSet<int> (a);
c.UnionWith(b);
PrintCollection(c);

// Intersection
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
PrintCollection(d);

// Difference
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);
PrintCollection(e);


Static void printCollection<T>(IEnumerable<T> collection) {
	foreach (T obj in collection) {
		Console.Write(obj + " ");
	}
	Console.WriteLine();

}


 */
/* Como as coleções Hash testam igualdade?
Se GetHashCode e Equals estiverem implementados
 * Primeiro GetHashCode. Se der igual, usa Equals para confirmar
 - Exemplo:
   HashSet<string> set = new HashSet<string>();
   
   set.Add("Maria);
   set.Add("Alex");

   Console.WriteLine(set.Contains("Maria")); // da True


Se GetHashCode e Equals NÃO estiverem implementados:
 * Tipos referência: compara as referências dos objetos
 * Tipos valor: comparar os valores dos atributos
 - Exemplo:  

HashSet<ProductServ> ps = new HashSet<ProductServ>();
ps.Add(new ProductServ("Tv", 900.0m));
ps.Add(new ProductServ("Notebook", 1200.0m));


HashSet<Point> pointer = new HashSet<Point>();
pointer.Add(new Point(3, 4));
pointer.Add(new Point(5, 10));

ProductServ prodServ = new ProductServ("Notebook", 1200.00m); 
Console.WriteLine(ps.Contains(prodServ)); // Precisa de um override no Equals e GetHashCode para comparar o conteudo e não a referencia!

Point p = new Point(5, 10); // Quando o tipo e struct ele compara por conteudo não referencia!
Console.WriteLine(b.Contians(p));
 */
/* Problema exemplo

Um site de internet registra um log de acessos dos usuários. Um registro
de log consiste no nome de usuario e o instante em que o usuario acessou
o site no padrão ISO 8601, separados por espaço, conforme exemplo. Fazer
um programa que leia o log de acessos a partir de um arquivo, e dai informe quantos
usuarios distintos acessaram o site

Exemplo:
Input file:
amanda 2020-08-26T20:45:08
alex86 2020-08-26T21:49:37
bobbrown 2020-08-27T03:19:13
jeniffer3 2020-08-27T09:19:24
alex86 2020-08-27T22:39:52
amanda 2020-08-28T07:42:19

Execution:
Enter file full path: c:\document\in.txt
Total users: 4

//C:\Users\Gamer\Documents\in
Console.Write("Enter file full path: ");
string path = Console.ReadLine();
HashSet<LogRecord> Records = new HashSet<LogRecord>();

try
{
    using (StreamReader sr = File.OpenText(path) )
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(" ");
            string username = line[0];
            DateTime instant = DateTime.Parse(line[1]);

            Records.Add(new LogRecord { Username = username, Instant = instant});

            
        }
    }
}
catch(IOException e) { Console.WriteLine(e.Message); }
Console.WriteLine($"Total Users: {Records.Count}");
*/
/* Exercício proposto sobre conjuntos 

Em um porta de cursos online, cada usuário possui um código único, representado
por um número inteiro.

Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno
pode se matricular em quantos cursos quiser. Assim, o número total de
alunos de um instrutor não é simplesmente a soma dos alunos de todos os cursos
que ele possui, pois pode haver alunos repetidos em mais de um curso.

O instruro Alex possui três cursos A,B e C e deseja saber seu número 
total de alunos.

Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex,
depois mostrar a quantidade total e alunos dele, conforme exemplo.

Exemplo:
How many students for course A? 3
21
35
22
How many students for course B? 2
21
50
How many students for course C? 3
42
35
13
Total students: 6

HashSet<StudentCourse> students = new HashSet<StudentCourse>();
Console.Write("How many students for course A? ");
int num1 = int.Parse(Console.ReadLine());
for (int i = 1; i <= num1; i++)
{
    int studentId = int.Parse(Console.ReadLine());
    students.Add(new StudentCourse { StudentId = studentId });
}
Console.Write("How many students for course B? ");
int num2 = int.Parse(Console.ReadLine());
for (int i = 1; i <= num2; i++)
{
    int studentId = int.Parse(Console.ReadLine());
    students.Add(new StudentCourse { StudentId = studentId });
}
Console.Write("How many students for course C? ");
int num3 = int.Parse(Console.ReadLine());
for (int i = 1; i <= num3; i++)
{
    int studentId = int.Parse(Console.ReadLine());
    students.Add(new StudentCourse { StudentId = studentId });
}
Console.WriteLine($"Total student: {students.Count}");
 */
/* Dictionary<TKey, TValue>

É uma coleção de pares chave/ valor
 Não admite repetições do objeto chave
 Os elementso são indexados pelo objeto chave (não possuem posição)
 Acesso, Inserção e remoção de elemtnos são rapidos

Uso comum: cookies, local storage, qualquer modelo chave-valor

Dictionary 
 Link:https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx
SortedDictionary
 Link:https://msdn.microsoft.com/en-us/library/f7fta44c(v=vs.110).aspx

Diferenças

- Dictionary
    Armazenamento em tabela hash
    Extremamente rápido: Inserção, remoção e busca O(1)
    A ordem dos elementos não são garantidas

- SortedDictionary
    Armazenamento em arvóre 
    Rápido: Inserção e busca O (log(n))
    Os elementos são armazenados ordenadamente conforme a implementação 
    IComparer<T>

Alguns métodos importantes
dictionary[key] - acessa o elemento pela chave informada

Add (Key, value) - adciona elemento (exceção em caso de repetição)
Clear() - esvazia a coleção
Count - quantidade de elementos
ContainsKey(Key) - verifica se a dada chave existe
ContainsValue(Value) - verifica se o dado valor existe
Remove(Key) - remove um elemento pela chave



Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["usser"] = "Maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "99712234";
cookies["phone"] = "83737388";

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'email' key");
}

Console.WriteLine($"Size:{cookies.Count}");
Console.WriteLine("All cookies:");
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine($"K:{item.Key} -> V:{item.Value}");
}
*/
/* Exercicio proposto sobre Dictionary

Na contagem de votos de uma eleição, são gerados vários registros de
votação contendo o nome do candidato e a quantidade de votos
(formato .csv) que ele obteve em uma urna de votação. Você deve fazer
um programa para ler os registros de votação a parir de um arquivo, e
daí gerar um relatório consolidado com os totais de cada candidato.

Exemplo:
Input file
Alex Blue,15
Maria Green,22
Bob Brown,21
Alex Blue,30
Bob Brown,15
Maria Green,27
Maria Green,22
Bob Brown,25
Alex Blue,31

Execution:
Enter file full path: c:\temp\in.txt
Alex Blue: 76
Maria Green:71
Bob Brown:61


//C:\Users\Gamer\Documents\in
Console.Write("Enter file full path: ");
string path = Console.ReadLine();
Dictionary<string,int> voteCount = new Dictionary<string,int>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(",");
            string candidateKey = line[0];
            int voteValue = int.Parse(line[1]);  
            

            if (!(voteCount.ContainsKey(candidateKey)))
            {
                voteCount[candidateKey] = voteValue;
            }
            else 
            {
                int oldValue = voteCount[candidateKey]; 
                voteCount[candidateKey] = oldValue + voteValue;
            }


        }
    }
}
catch (IOException e) { Console.WriteLine(e.Message); }
foreach (KeyValuePair<string, int> item in voteCount) 
{
    Console.WriteLine($"{item.Key}:{item.Value}");
}
*/
/* Extension methods 
São metodos que estendem a funcionalidade de um tipo, sem preicsar alterar
o codigo fonte deste tipo, nem herdar desse tipo.

Como fazer um extension method?
 -Criar uma classe estática
 -Na classe, criar um método estático
 -O primeiro parâmetro do método deverá ter o prefixo this, seguido da
  declaração de um parâmetro do tipo que se deseja estender. Esta será
  uma referência para o próprio objeto.

Demo 1

Vamos criar um extension method chamado "ElapsedTime()" no struct
DateTime para apresentar um objeto DateTime na forma de tempo
decorrido, podendo ser em horas (se menor que 24h) ou em dias caso
contrário. Por exemplo:

DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45)
Console.WriteLine(dt.ElapsedTime()); // "4.5 hours" ou caso mude os dias "3.2 days"

Exemplo abaixo:

Nota: Em classes para Extension criar uma pasta chamada Extensions
e guarda-las la!


static class DateTimeExtensions
{
	public static string ElapsedTime(this DateTime thisObj)
	{
		TimeSpan duration = DateTime.Now.Subtract(thisObj);
	
		if (duration.TotalHours < 24.0){ return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";} 
		else { return duration.TotalDays.ToString("F1",CultureInfo.InvariantCulture) + " days";}
	}

}

Demo 2 

Vamos criar um extension method chamado "Cut(int)" na classe string
para receber um valor inteiro como parâmetro e gerar um recorte do string original daquele tamanho por exemplo:

String s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(10)); // "Good morni..."


Exemplo abaixo:

static class StringExtensions
{
	public static string Cut(this string thisObj, int count )
	{
		if(thisObj.Length <= count)
		{	
			return thisObj;
		}
		else
		{
			return thisObj.Substring(0, count) + "...";
		}
	}
}


*/
/* Uma experiencia com Comparison<T>

Problema

Suponha uma classe Product com os atributos name e price suponha
que precisamos ordernar uma lista de objetos Product.

Podemos implementar a comparação de produtos por meio da implementação da interface ]
IComparable<Product> 

Entretanto, desta forma nossa classe não fica fechada para alteração:
se o criteiro de comparação mudar, precisaremos alterar a classe Product.

Podemos então usar outra sobrecarga do método "Sort" da classe List:
 public void Sort(Comparison<T> comparison) 

Product
- name : String
- price : Double

Exemplo abaixo:
- Program principal:

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00m));
list.Add(new Product("Notebook", 1200.00m));
list.Add(new Product("Tablet", 450.00m));

// Definição de função lambda, Ela não precisa ser declarada para funcionar pois ele serão inferidos!
// Funciona como uma expressão lambda
// Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

list.Sort(compareProducts);

foreach (Product p in list)
{
	Console.WriteLine(p);
}

- Pasta entities - ProductComp:
class Product : IComparable<Product> 
{
	public string Name { get; set; }
	public decimal Price { get; set; }
	
	public Product (string name, decimal price) 
	{
		Name = name;
		Price = price;
	}

	public override string ToString() 
	{
		return $"{Name}, {Price.ToString("F2",CultureInfo.InvariantCulture)}"
	}
	public int CompareTo(Product other) 
	{
		//return Name.ToUpper().CompareTo(other.Name.ToUpper());
		return Price.CompareTo(other.Price)
	}


}

Comparison<T> (System)
Link: https://msdn.microsoft.com/en-us/library/tfakywbh(v=vs.110).aspx

public delegate int Comparison<in T> (T x , T y);

Metodo Sort com Comparison<T> da classe List:
Link: https://msdn.microsoft.com/en-us/library/w56d4y5z%28v=vs.110%29.aspx

Resumo da aula!!!

public void Sort(Comparison<T> comparison)

* Referência simples de método como parâmetro
* Referência de método atribuído a uma variável tipo delegate
* Expressão lambda atribuída a uma variável tipo delegate
* Expressão lambda inline





*/
/* Programação Funcional e Cálculo Lambda
Paradigmas de programação!!!
* Imperativo (C, Pascal, Fortran, Cobol)
* Orientado a objetos (C++,Object Pascal, Java (<8), C# <3))
* Funcional (Haskell, Closure, Clean, Erlang)
* Lógico (Prolog)
* Multiparadigma (JavaScript, Java (8+), C#(3+), Ruby, Python, Go)

+-------------------------------------------+--------------------------------+------------------------------------+
|					                        | Programação imperativa	     | Programação funcional 	          |
+-------------------------------------------+--------------------------------+------------------------------------+
| Como se descreve algo a ser computado (*) | Comandos ("como" - imperativa) | Expressões ("o quê" - declarativa) |
+-------------------------------------------+--------------------------------+------------------------------------+
| Funções possuem transparência referencial | Fraco 	        		     | Forte			            	  |
| (ausência de efeitos colaterais)	        |            				     |				 	                  |
+-------------------------------------------+--------------------------------+------------------------------------+
| Objetos imutáveis (*) 		            | Raro 			                 | Comum                              |
+-------------------------------------------+--------------------------------+------------------------------------+
| Funções são objetos de primeira ordem     | Não			                 | Sim               				  |
+-------------------------------------------+--------------------------------+------------------------------------+
| Expressividade / Código conciso 	        | Baixa         			     | Alta	                			  |
+-------------------------------------------+--------------------------------+------------------------------------+
| Inferência de tipos 			            | Raro	            		     | Comum 		            		  |
+-------------------------------------------+--------------------------------+------------------------------------+
| Execução tardia (lazy)		             | Raro			                 | Comum		            		  |
+-------------------------------------------+--------------------------------+------------------------------------+

Exemplo de expressividade / "como" vs. "o quê"

int sum = 0; 
foreach (int x in list) {
	sum += x;
}

vs

int sum = list.Aggregate(0, (x, y) => x + y);

Legenda da tabela:
- Funções possuem transparência referencial: Uma função possui transparência referencial se seu resultado for sempre o mesmo para os mesmos dados de entrada. Beneficios: simplicidade e previsibilidade

Exemplo de função que não é referencialmente transparente
int[] vect = new int [] { 3, 4, 5 };
ChangeOddValues(vect)
Console.WriteLine(string.Join(" ", vect));

public static void ChangeOddValues(int[] numbers) 
{
	for(int i = 0; i < numbers.Length; i++) 
	{
		if (numbers[i] % 2 != 0) 
		{
			numbers[i] += globalValue;
		}
	}
}

- Objetos imutáveis (*): São mais faceis de entender e podem ser paralelizados (thread safe)
- Funções são objetos de primeira ordem: Isso significa que funções podem, por exemplo serem passadas como parâmetros de métodos
  bem como retornadas como resultado de métodos.

static int ComapreProducts(Product p1, Product p2) 
{
	return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}

List<Product> list = new List<Product>();

list.Add(new Product("TV",900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

list.Sort(CompareProducts);

- Inferencia de tipos: E quando não é preciso declarar o tipo da variavel
- Execução tardia (lazy): Voce define uma expressão pra ele so que essa expressão so vai ser executada quando ela tiver efetivamente do resultado dela

- Cálculo Lambda = Formalismo matemático base da programação funcional
- Expressão lambda = função anônima de primeira classe 

*/
/* Introdução a delegates
Delegates
Link: https://docs.microsoft.com/en-us/dotnet/standard/delegates-lambda

É uma referência (com type safety) para um ou mais métodos
 É um tipo de referência

Usos comuns:
 Comunicação entre objetos de forma flexível e extensível (eventos / callbacks)
 Parametrização de operações por métodos (programação funcional)

Delegates pré definidos como Action, Func e Predicate

Exemplo de demonstração de declaração do delegate
No program main:
delegate double BinaryNumericOperation(double n1, double n2);
// Delegate não aceitara a função square por que não casa com assinatura do delegate


double a = 10;
double b = 12;

//BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum); // So que fica verboso esse metodo
//BinaryNumericOperation op = CalculationSerivce.Sum;
BinaryNumericOperation op = CalculationService.Max;

double result = op(a,b); // Usou a operação Sum ou Max
// double result = op.Invoke(a,b)
//double result = CalculationService.Sum(a,b);
Console.WriteLine(result);


Em uma pasta service, CalculationService:
class CalculationService
{
	public static double Max(double x, double y)
	{
		return (x > y) ? x : y;
	}
	public static double Sum(double x, double y)
	{
		return x + y;
	}
	public static double Square (double x) 
	{
		return x * x;
	}

}
*/
/* Multicast delegates

- Delegates que guardam a referência para mais de um método 
- Para adicionar uma referência pode-se usar o operador +=
- A chamada Invoke (ou sintaxe reduizda) executa todos os métodos na ordem em que
  foram adicionados
- Seu uso faz sentido para métodos void

exemplo:
no Calculation Service:
class CalculationService 
{
	public static void ShowMax(double x, double y) {
		double max = (x > y) ? x : y;
		Console.WriteLine(max);
	}
	
	public static void ShowSum(double x, double y) {
		double sum = x + y
		Console.WriteLine(sum);
	}
}


*/
/* Predicate (System)
- Representa um método que recebe um objeto do tipo T e retorna um valor booleano
  Link:https://msdn.microsoft.com/en-us/library/bfcke1bz%28v=vs.110%29.aspx

public delegate bool Predicate<in T>(T obj);

Problema exemplo
Fazer um programa que, a partir de uma lista de produtos remova da lista somenete aqueles
cujo preço seja acima de 100.
Exemplo:
No program main
List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00)); 
list.Add(new Product("Mouse", 50.00)); 
list.Add(new Product("Tablet", 350.50)); 
list.Add(new Product("HD Case", 80.90)); 

list.RemoveAll(ProductTest);
foreach (Product p in list){
	Console.WriteLine(p);
}

public static bool ProductTest(Product p){
	return p.Price >= 100;
}

No class product:
class Product:
{
	public string Name { get; set; }
	public double Price { get; set; }
	
	public Product (string Name, double Price)
	{
		Name = name;
		Price = price;
	}

	public override string ToString() {
		return $"{Name}, {Price.ToString("F2")}"
	}
}


*/
/* Action (exemplo com ForEach)
Representa um método void que recebe zero ou mais argumentos
Link:https://msdn.microsoft.com/en-us/library/system.action%28v=vs.110%29.aspx

public delegate void Action();
public delegate void Action<in T>(T obj);
public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
(16 sobrecargas)

Problema exemplo:
Fazer um programa que, a partir de uma lista de produtos, aumente
o preço dos produtos em 10%


No program main
List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00)); 
list.Add(new Product("Mouse", 50.00)); 
list.Add(new Product("Tablet", 350.50)); 
list.Add(new Product("HD Case", 80.90)); 

Action<Product> act = p => {p.Price += p.Price * 0.1;}
//Action<Product> act = UpdatePrice;

list.ForEach(act)
//list.ForEach(UpdatePrice);
//list.ForEach(p => {p.Price += p.Price * 0.1;});
foreach (Product p in list){
	Console.WriteLine(p);
}

static void UpdatePrice (Product p){
	p.Price += p.Price * 0.1;
}



No class product:
class Product:
{
	public string Name { get; set; }
	public double Price { get; set; }
	
	public Product (string Name, double Price)
	{
		Name = name;
		Price = price;
	}

	public override string ToString() {
		return $"{Name}, {Price.ToString("F2")}"
	}
}

*/
/* Func (exemplo com Select)
Representa um método que recebe zero ou mais argumentos, e retorna um valor
Link:https://msdn.microsoft.com/en-us/library/bb534960%28v=vs.110%29.aspx

public delegate TResult Func<out Tresult>();
public delegate TResult Func<in T, out Tresult>(T obj);
public delegate TResult Func<in T1, in T2, out Tresult>(T1 arg1, T2 arg2);
public delegate TResult Func<in T1, in T2, in T3, out Tresult>(T1 arg1, T2, arg2, T3 arg3);
(16 Sobrecargas)

Problema exemplo
Fazer um programa que, a partir de uma lista de produtos, gere uma 
nova lista contendo os nomes dos produtos em caixa alta.

No program main
List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00)); 
list.Add(new Product("Mouse", 50.00)); 
list.Add(new Product("Tablet", 350.50)); 
list.Add(new Product("HD Case", 80.90)); 

Func<Product, string> func = p => p.Name.ToUpper(); // Função lambda
// Se tiver chaves a expressão lambda vai esperar um comando nomral como return! mas sem isso e so desse jeito acima


List<string> reuslt = list.Select(func).ToList();
// List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); // Versão lambda inline!
foreach(string s in result){
	Console.WriteLine(s);
}



No class product:
class Product:
{
	public string Name { get; set; }
	public double Price { get; set; }
	
	public Product (string Name, double Price)
	{
		Name = name;
		Price = price;
	}

	public override string ToString() {
		return $"{Name}, {Price.ToString("F2")}"
	}
}



*/
/* LINQ - Language Integrated Query
É um conjunto de tecnologias baseadas na integração de funcionalidade de
consulta diretamente na linguagem C#
 - Operações chamadas diretamente a partir de coleções
 - Consultas são objetos de primeira classe
 - Suporte do compilador e InteliSense da IDE

Namespace:System.Linq

Possui diversas operações de consulta, cujos parâmetros tipicamente
são expressões lambda ou expressões de sintaxe similiar á SQL

Ref:https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/index

Três passos 
- Criar um data source (coleção, array, recurso de E/S, etc.)
- Definir a query
- Executar a query (foreach ou alguma operação terminal)

+----------+	   +--------+	    +---------+
|Datasource| ----> |Query   | ----> |Execution|
+----------+	   +--------+       +---------+

Exemplo:

// Specify the data source
int[] numbers = new int[] { 2, 3, 4, 5 };

// Define the query expression
var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

foreach(var number in result)
{
    Console.WriteLine(number);
}
*/
/*Operações do LINQ/ Referências

- Filtering: Where, OfType						- Grouping: GroupBy
- Sorting OrderBy, OrderByDescending, ThenBy, ThenByDescending,Reverse  - Generational: Empty
- Set: Distinct, Except, Intersect, Union				- Equality: SequenceEquals
- Quantification: All, Any, Contains					- Element: ElementAt, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOurDefault
- Projection: Select, SelectMany					- Conversions: AsEnumerable, AsQuerryable	   
- Partition: Skip, Take							- Concatenation: Concat
- Join: Join, GroupJoin							- Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum

*/
/* Demo - LINQ com lambda - Parte 1

+-----------------+		+-----------------+
|      Product    |		|     Category    |
+-----------------+		+-----------------+
|- Id : Integer   |		|- Id : Integer   |
|- Name : String  | ------>     |- Name : String  |
|- Price : Double |		|- Tier : Integer |
+-----------------+		+-----------------+
+-----------------+		+-----------------+


Na pasta entities, classe category
class Category {
	public int Id { get; set; }
	public string Name { get; set; }
	public int Tier { get; set; }
}

Na pasta entities, classe Product
class Product {
	public int Id { get; set; }
	public string Name { get; set; }
	public double Price { get; set; }
	public Category Category { get; set; }

public override string ToString(){
	return $"{Id}, {Name}, {Price.ToString("F2",CultureInfo.InvariantCulture)}, {Category.Name}, {Category.Tier}"
	}
}
No program main

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

List<ProductLINQ> products = new List<ProductLINQ>() {
	new ProductLINQ() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
	new ProductLINQ() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
	new ProductLINQ() { Id = 3, Name = "Tv", Price = 1700.0, Category = c3 },
	new ProductLINQ() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
	new ProductLINQ() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
	new ProductLINQ() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
	new ProductLINQ() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
	new ProductLINQ() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
	new ProductLINQ() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
	new ProductLINQ() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
	new ProductLINQ() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
};

//var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
var r1 = 
    from p in products 
    where p.Category.Tier == 1 && p.Price < 900.0
    select p;
Print("TIER 1 AND PRICE < 900.00:", r1);

//var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
var r2 =
    from p in products
    where p.Category.Name == "Tools"
    select p.Name;
Print("NAME OF PRODUCTS FROM TOOLS", r2);

//var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { ProductName = p.Name, ProductPrice = p.Price, CategoryName = p.Category.Name });
var r3 =
    from p in products
    where p.Name[0] == 'C'
    select new {
        p.Name,
        p.Price,
        CategoryName = p.Category.Name,
    };
Print("NAMES STARTED WITH 'C' AND ANONYMUS OBJECT", r3);

//var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
var r4 =
    from p in products
    where p.Category.Tier == 1
    orderby p.Name
    orderby p.Price
    select p;
Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

//var r5 = r4.Skip(2).Take(4);
var r5 =
    (from p in r4
     select p).Skip(2).Take(4);
Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

// var r6 = products.FirstOrDefault();
var r6 = (from p in products select p).FirstOrDefault();
Console.WriteLine($"First or defeault test1: {r6}");

//var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
var r7 =
    (from p in products
     where p.Price > 3000.0
     select p).FirstOrDefault();
Console.WriteLine($"First or defeault test2: {r7}");

// So usar para um ou nenhum elemento no retorno!!!
var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine($"Single or defeault test1: {r8}");

var r9 = products.Where(p => p.Id == 16).SingleOrDefault();
Console.WriteLine($"Single or defeault test2: {r9}");

var r10 = products.Max(p => p.Price);
Console.WriteLine($"Max price: {r10}");

var r11 = products.Min(p => p.Price);
Console.WriteLine($"Min price: {r11}");

var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine($"Category 1 Sum prices: {r12}");


var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine($"Category 1 Average prices: {r13}");

var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine($"Category 5 Average prices: {r14}");
// no r15 e possivel definir o valor inicial! em caso de que seja vazio o conteudo
var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine($"Category 1 Aggregate sum: {r15}");

//var 16 = products.GroupBy(p => p.Category);
var r16 =
    from p in products
    group p by p.Category;
foreach (IGrouping<Category, Product> group in r16)
{
    Console.WriteLine($"Category {group.Key.Name}:");
    foreach (Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
}

static void Print<T>(string message, IEnumerable<T> collection){
	Console.WriteLine(message);
	foreach (T obj in collection) 
	{
		Console.WriteLine(obj);
	}
	Console.WriteLine();
}
*/
/* Da aula de LINQ
Resumo da aula 

- Where (Operação "filter" / "restrição")
- Select (Operação "map" / "projeção")
- OrderBy, OrderByDescending, ThenBy, ThenByDescending
- Skip, Take
- First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
- Max, Min, Count, Sum, Average, Aggregate(operação "reduce")
- GroupBy

link:https://github.com/acenelio/linq-demo1
*/
/* Exercicios resolvido modulo 15
Fazer um programa para ler um conjunto de produtos a partir de um arquivo em
formato.csv (suponha que exista pelo menos um produto).

Em seguida mostrar o preço médio dos produtos. Depois, mostrar os nomes,
em ordem decresente, dos produtos que possuem preço inferior ao preço médio.

Veja exemplo na próxima página.

Link correção:https://github.com/acenelio/lambda6-csharp

Input file:
Tv, 900.00
Mouse, 50.00
Tablet, 350.00
HD Case, 80.90
Computer, 850.00
Monitor, 290.00

Execution:
Enter full file path: c:\temp\input.txt
Average price: 420.23
Tablet
Mouse
Monitor
HD Case

Console.Write("Enter full file path: ");
string path = Console.ReadLine();//"c:\Users\Gamer\Downloads\input.txt";
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<ProductExercicio> Listing = new List<ProductExercicio>();
        while (!sr.EndOfStream)
        {
            var splitter = sr.ReadLine().Split(',');
            string productName = splitter[0];
            decimal productPricing = decimal.Parse(splitter[1],CultureInfo.InvariantCulture);

            Listing.Add(new ProductExercicio(productName,productPricing));
        }
        var avg = Listing.Select(p => p.Price).DefaultIfEmpty(0.0m).Average();
        Console.WriteLine($"Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");

        var names = Listing.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
        foreach (string name in names) 
        {
            Console.WriteLine(name);
        }

    }   
}
catch (IOException e)
{
    Console.WriteLine($"An error as ocurred\n {e.Message}");
}
*/
/* Exercicio de fixação modulo 15
Fazer um programa para ler os dados (nome, email e salario)
de funcionarios a partir de um arquivo em formato.csv

Em seguida mostrar, em ordem alfabetica, o email dos funcionarios cujo salario
seja superior a um dado valor fornecido pelo usuario

Mostrar tambem a soma dos salarios dos funcionarios cujo nome começa com
a letra 'M'.
veja exemplo na proxima pagina

Link:https://github.com/acenelio/lambda7-csharp
Input file:
Maria,maria@gmail.com,3200.00
Alex,alex@gmail.com,1900.00
Marco,marco@gmail.com,1700.00
Bob,bob@gmail.com,3500.00
Anna,anna@gmail.com,2800.00

Exeuction:
Enter full file path: //"c:\Users\Gamer\Downloads\input.txt";
Enter salary: 2000.00
Email of people whose salary is more than 2000.00:
anna@gmail.com
bob@gmail.com
maria@gmail.com
Sum of salary of people whose name starts with 'M': 4900.00

Console.Write("Enter full file path: ");
string path = Console.ReadLine();//"c:\Users\Gamer\Downloads\input.txt";
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee32> Listing = new List<Employee32>();
        while (!sr.EndOfStream)
        {
            var splitter = sr.ReadLine().Split(',');
            string EmpName = splitter[0];
            string EmpEmail = splitter[1];
            decimal EmpSalary = decimal.Parse(splitter[2], CultureInfo.InvariantCulture);

            Listing.Add(new Employee32(EmpName, EmpEmail, EmpSalary));
        }
        Console.Write("Enter Salary:");
        decimal Salary123 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var placeholder = Listing.Where(l => l.Salary > 2000.00m).OrderBy(l => l.Email).Select(l => l.Email);
        Console.WriteLine("Email of people whose salary is more than 2000.00:");
        foreach (string emp in placeholder)
        {
            Console.WriteLine(emp);
        }
        decimal sum = Listing.Where(l => l.Name[0] == 'M').Select(l => l.Salary).DefaultIfEmpty(0.0m).Sum();
        Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2",CultureInfo.InvariantCulture)}");

    }
}
catch (IOException e)
{
    Console.WriteLine($"An error as ocurred\n {e.Message}");
}
 */
// See https://aka.ms/new-console-template for more information
using Curso2.ClassesCurso;
using System.Collections.Generic;
using System.Globalization;
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
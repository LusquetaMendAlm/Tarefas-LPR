/*Exercício 2) Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir,
calcule e mostre a diferença do produto de A e B pelo produto de C e D
*/

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            Console.WriteLine("Diferença:" + ((A * B)-(C *D )));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagulho_do_zé
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QantPar = 0;
            int contador = 0;
            double media;
            double n;
            int nums;
            double soma = 0;
            Console.WriteLine("Quantos números você irá digitar?");
            nums = int.Parse(Console.ReadLine());
            while (nums > contador)
            {
                Console.WriteLine("Digite um número, lembrando que não números ímpares não farão parte da média");
                n = double.Parse(Console.ReadLine());
                if (n % 2 ==0)
                {
                      soma = n + soma;
                        QantPar++;

                }
                contador++;
            }
            media = soma / QantPar;
            Console.WriteLine("Descontando os números ímpares, a média dessa sequência é: " + media);
        }
    }
}

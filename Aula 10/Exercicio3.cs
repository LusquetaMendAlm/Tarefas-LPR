using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            ushort quant;
            double  media;
            Dictionary<string, int> idadeDasPessoas = new();
            Console.WriteLine("Digite quantas pessoas você irá adicionar: ");
            quant = ushort.Parse(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o nome e idade da pessoa: ");
                idadeDasPessoas.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }

            foreach (var i in idadeDasPessoas) {
                soma += i.Value;
            }
            media = soma / quant;
            foreach (var i in idadeDasPessoas)
            {
                if(i.Value > media)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}


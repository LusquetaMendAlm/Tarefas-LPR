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
            double media;
            int maiorValor = int.MinValue;
            string PessoaVelha = null;
            int menorValor = int.MaxValue;
            string PessoaNova = null;
            Dictionary<string, int> idadeDasPessoas = new();
            Console.WriteLine("Digite quantas pessoas você irá adicionar: ");
            quant = ushort.Parse(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o nome e idade da pessoa: ");
                idadeDasPessoas.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }

            foreach (var i in idadeDasPessoas)
            {
                soma += i.Value;
            }
            media = soma / quant;
            Console.WriteLine("Estas são as pessoas que estão acima da média de idade: ");
            foreach (var i in idadeDasPessoas)
            {
                if (i.Value > media)
                {
                    Console.WriteLine(i);
                }
            }
            foreach (var par in idadeDasPessoas)
            {
                if (par.Value < menorValor)
                {
                    menorValor = par.Value;
                    PessoaNova = par.Key;
                }
            }
            foreach (var par in idadeDasPessoas)
            {
                if (par.Value > maiorValor)
                {
                    maiorValor = par.Value;
                    PessoaVelha = par.Key;
                }
            }
            Console.WriteLine("Estas são a pessoa mais nova e a pessoa mais velha: ");
            Console.WriteLine(PessoaVelha);
            Console.WriteLine(PessoaNova);

            Console.WriteLine("Digite um idade para retirar do dicionário: ");
            int idade = int.Parse(Console.ReadLine());
            bool temIdade = idadeDasPessoas.ContainsValue(18);
            if(temIdade == true)
            {
                idadeDasPessoas.Remove("");
            }
        }
    }
}

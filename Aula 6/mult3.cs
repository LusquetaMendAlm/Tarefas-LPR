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
            int soma=0;
            for (int i = 51; i<= 500; i=i+6)
            {
                soma = soma + i;
            }
            Console.WriteLine("A soma dos múltiplos de 3 ímpares até 500 é de :" + soma);
        }   
    }
}

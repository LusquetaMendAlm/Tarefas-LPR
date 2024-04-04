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
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1, 100);
            int nUsuario;
            int contador = 0;
            Console.WriteLine("Tente adivinhar um número de 1 a 100.");
            do
            {
                Console.WriteLine("Digite um número");
                nUsuario = int.Parse(Console.ReadLine());
                contador++;
                if (nUsuario == valorInteiro)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    Console.WriteLine("Você demorou " + contador + " tentativas para acertar.");
                }
                else if (nUsuario > valorInteiro)
                {
                    Console.WriteLine("Chutou alto");
                }
                else if (nUsuario < valorInteiro)
                {
                    Console.WriteLine("Chutou baixo");
                }
            } while (nUsuario != valorInteiro);
        }   
    }
}

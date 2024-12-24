/*Exercício 1) Faça um programa para ler o valor do raio de um círculo, e depois
mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
Fórmula da área: area = π.raio2
Considere o valor de π = 3.14159
*/

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float area;
            float raio;
            float pi = 3.14159f;
            raio = float.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("Área: " + area.ToString("F4"));
        }
    }
}

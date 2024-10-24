namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new();
            Console.WriteLine("Digite a altura e em seguida a largura do retângulo.");
            retangulo.altura = double.Parse(Console.ReadLine());
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Para esse retângulo, as medidas são:");
            retangulo.calcArea();
            retangulo.calcPerimetro();
        }
    }
}

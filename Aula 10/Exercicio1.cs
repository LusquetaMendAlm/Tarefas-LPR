using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();
        List<string> lista3 = new List<string>();
        List<string> lista4 = new List<string>();
        List<string> Nomes = new List<string>();

        ushort NumsNomes;
        Console.WriteLine("Quantos nomes você irá digitar: ");
        NumsNomes = ushort.Parse(Console.ReadLine());
        for (int i = 0; i < NumsNomes; i++)
        {
            Console.WriteLine("Digite um nome:");
            Nomes.Add(Console.ReadLine());
        }
        for (int i = 0; i < NumsNomes; i++)
        {

        }
    }
    public static int NumeroDeLetras (string nome)
    {
        int contador = 0;
        return contador;
    }
}
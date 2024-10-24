using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Retangulo
    {
        //Os atributos e métodos precisam ser "internal" ou "public" para que as outras classes os acessem
        internal double altura;
        internal double largura;

        internal void calcArea()
        {
            Console.WriteLine("Área: " + (altura * largura));
            
        }
        internal void calcPerimetro()
        {
            Console.WriteLine("Perimêtro: " + (2 * ( altura + largura)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Funcionario
    {
        internal string nome;
        internal double salarioBruto;
        internal double salarioAumentado;
        internal int imposto;


        internal void imprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salário líquido: " + salarioBruto);
        }
        
        internal void aumentoSalario()
        {
            salarioAumentado = salarioBruto;

            if(salarioBruto <= 2000)
            {
                imposto = 10;
            }
            else if(salarioBruto >2000 && salarioBruto <= 3000)
            {
                imposto = 15;
            }
            else if(salarioBruto > 3000)
            {
                imposto = 20;
            }
            
            salarioAumentado += salarioBruto * imposto / 100;
            salarioBruto = salarioAumentado;

            Console.WriteLine("R$" + salarioAumentado.ToString("F2"));
        }
        
    }
}

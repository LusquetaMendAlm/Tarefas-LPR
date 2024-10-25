namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int escolha;
            bool continuar = true;

            Funcionario funcionario = new();
            Console.WriteLine("Digite o nome do funcionário: ");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());

            while(continuar == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite um dos números:");
                Console.WriteLine("1. Mostrar informações do funcionário;");
                Console.WriteLine("2. Aumentar o salário do funcionário;");
                Console.WriteLine("3. Sair.");

                escolha = int.Parse(Console.ReadLine());

                switch(escolha){
                    case 1:
                        funcionario.imprimirDados();
                        break;
                    case 2:
                        funcionario.aumentoSalario();
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Esse número não pode");
                        break;
                }
                
                
            }
        }
    }
}

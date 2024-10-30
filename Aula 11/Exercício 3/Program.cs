namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            bool continuar = true;

            Aluno aluno = new();
            Console.WriteLine("Digite a matrícula do aluno: ");
            aluno.matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do aluno:");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite a nota da primeira prova:");
            aluno.prova1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova:");
            aluno.prova2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do trabalho:");
            aluno.trabalho = int.Parse(Console.ReadLine());

            while (continuar == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite um dos números:");
                Console.WriteLine("1. Fazer a média das notas;");
                Console.WriteLine("2. Verificar quanto de nota precisa na final;");
                Console.WriteLine("3. Sair.");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Média: " + aluno.media());
                        break;
                    case 2:
                        Console.WriteLine("A nota necessária é " + aluno.final());
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

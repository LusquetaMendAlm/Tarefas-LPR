using System;
class Program
{
    static void Main()
    {
        var mn = new Program();
        Console.WriteLine("Bem-vindo ao Marvel's Game!");
        mn.menuPrincipal();
    }
    public void menuPrincipal()
    {
        int menu;
        bool quit = false;
        while (quit == false)
        {
        Console.WriteLine("Menu Principal");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1) Cadastrar seus heróis");
        Console.WriteLine("2) Selecionar sua equipe");
        Console.WriteLine("3) Exibir sua equipe");
        Console.WriteLine("4) Quit Game");
        menu = int.Parse(Console.ReadLine());
        switch (menu)
            {
            case 1:
                cadastrarHerois();
            break;
            case 2:
                selecionarEquipe();
            break;
            case 3:
                exibirEquipe();
            break;
            case 4:
                Console.WriteLine("OK, Saindo do jogo...");
                quit = true;
            break;
            default:
                Console.WriteLine("ERRO: O número inserido é inválido");
            break;
            }
        }
    }
    public void cadastrarHerois()
    {
        int x = 1;
        int mais = 1;
        string nome1, nome2, nome3, nome4, nome5;
        string poder1, poder2, poder3, poder4, poder5;
        int pont1, pont2, pont3, pont4, pont5;
        while(x<=5 && mais == 1)
        {
            Console.WriteLine("Digite o nome do seu herói "+x+": ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o poder do seu herói "+x+" em uma palavra: ");
            poder1 = Console.ReadLine();
            Console.WriteLine("Digite a pontuação do seu herói "+x+" do seu herói: ");
            pont1 = int.Parse(Console.ReadLine());
            Console.WriteLine("OK, cadastro do herói "+x+" finalizado.");
            x++;
            Console.WriteLine("Deseja colocar mais heróis? 1)Sim. 2)Não");
            mais = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Todos os cadastros foram realizados.");
        Console.WriteLine("Voltando para o menu...");
        menuPrincipal();
    }
    public void selecionarEquipe()
    {

    }
    public void exibirEquipe()
    {

    }
    public void calcularPontuacaoTotal()
    {

    }
}
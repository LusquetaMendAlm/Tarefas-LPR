using System;
class Program
{
    public struct Heroi{
        public string nome;
        public string poder;
        public short pontuacao;
    }
    static Heroi[] herois = new Heroi[5]; 
    static short equipe1, equipe2, equipe3;
    static void Main()
    {
        int menu;
        bool quit = false;
        
        Console.WriteLine("Bem-vindo ao Marvel's Game!");
        
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
                Console.WriteLine("ERRO: O número inserido é inválido");;
            }
        }
    }
    public void cadastrarHerois()
    {
        for(short i = 0 ; i<5 ; i++) {
            Console.WriteLine("Digite o nome do herói "+(i+1)+": ");
            herois[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o poder do herói "+(i+1)+": ");
            herois[i].poder = Console.ReadLine();
            Console.WriteLine("Digite a pontuação do herói "+(i+1)+": ");
            herois[i].pontuacao = short.Parse(Console.ReadLine());
            Console.WriteLine("O herói "+(i+1)+" foi regitrado!!!");
        }
    }
    public void selecionarEquipe()
    {
        for(short i = 0 ; i<5 ; i++) {
            Console.WriteLine($"1. {herois[i].nome} - {herois[i].nome} - Pontuação: {herois[i].nome}");
        }
        Console.Write("Selecione o herói 1: ");
        equipe1 = short.Parse(Console.ReadLine());
        Console.Write("Selecione o herói 2: ");
        equipe2 = short.Parse(Console.ReadLine());
        Console.Write("Selecione o herói 3: ");
        equipe3 = short.Parse(Console.ReadLine());
        
        Console.WriteLine("Equipe selecionada com sucesso!");
    }
    public void exibirEquipe()
    {
        switch(equipe1){
            case 1: Console.WriteLine(herois[0].nome); break;
            case 2: Console.WriteLine(herois[1].nome); break;
            case 3: Console.WriteLine(herois[2].nome); break;
            case 4: Console.WriteLine(herois[3].nome); break;
            case 5: Console.WriteLine(herois[4].nome); break;
        }
        switch(equipe2){
            case 1: Console.WriteLine(herois[0].nome); break;
            case 2: Console.WriteLine(herois[1].nome); break;
            case 3: Console.WriteLine(herois[2].nome); break;
            case 4: Console.WriteLine(herois[3].nome); break;
            case 5: Console.WriteLine(herois[4].nome); break;
        }
        switch(equipe3){
            case 1: Console.WriteLine(herois[0].nome); break;
            case 2: Console.WriteLine(herois[1].nome); break;
            case 3: Console.WriteLine(herois[2].nome); break;
            case 4: Console.WriteLine(herois[3].nome); break;
            case 5: Console.WriteLine(herois[4].nome); break;
        }
    }
    public void calcularPontuacaoTotal()
    {
        short p1 = 0, p2 = 0, p3 = 0;
        switch(equipe1){
            case 1: p1 = herois[0].pontuacao; break;
            case 2: p1 = herois[1].pontuacao; break;
            case 3: p1 = herois[2].pontuacao; break;
            case 4: p1 = herois[3].pontuacao; break;
            case 5: p1 = herois[4].pontuacao; break;
        }
        switch(equipe2){
            case 1: p2 = herois[0].pontuacao; break;
            case 2: p2 = herois[1].pontuacao; break;
            case 3: p2 = herois[2].pontuacao; break;
            case 4: p2 = herois[3].pontuacao; break;
            case 5: p2 = herois[4].pontuacao; break;
        }
        switch(equipe3){
            case 1: p3 = herois[0].pontuacao; break;
            case 2: p3 = herois[1].pontuacao; break;
            case 3: p3 = herois[2].pontuacao; break;
            case 4: p3 = herois[3].pontuacao; break;
            case 5: p3 = herois[4].pontuacao; break;
        }
        short pontuacaoTotal = p1 + p2 + p3;
        Console.WriteLine("Pontuação total da equipe: " + pontuacaoTotal);
    }
}
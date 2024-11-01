namespace Getter_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIANDO MEU OBJETO
            var aluno1 = new Aluno("Lucas", 34);

            //PILAR DO ENCAPSULAMENTO: NÃO PODE ISSO!!!
            //aluno1.nome = "Luquinha";
            //Console.WriteLine(aluno1.nome);

            //ACESSO AO ATRIBUTO POR MÉTODO GET
            //Console.WriteLine(aluno1.getNome());
            //var x = aluno1.getNome();

            ////ALTERAÇÃO DE ATRIBUTO POR MÉTODO SET
            //aluno1.setNome("Luquinha");
            //Console.WriteLine(aluno1.getNome()); //TESTE
            //string y = "Lusqueta";
            //aluno1.setNome(y);
            //Console.WriteLine(aluno1.getNome()); //TESTE

            //ACESSO AO ATRIBUTO POR MÉTODO GET
            Console.WriteLine(aluno1.Nome);
            var x = aluno1.Nome;

            //ALTERAÇÃO DE ATRIBUTO POR MÉTODO SET
            aluno1.Nome = "Lusquinha";
            Console.WriteLine(aluno1.Nome); //TESTE

        }
    }
}
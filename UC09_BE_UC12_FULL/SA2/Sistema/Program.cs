
namespace Sistema
{
    class Program{
        static void Main(string[] args)
        {
            Pessoa Pessoa1 = new Pessoa();
            Pessoa andre = new Pessoa();
            Pessoa lucas = new Pessoa();
            Pessoa raffael = new Pessoa();

            Pessoa1.Endereco = "qualquercoisa";
            Pessoa1.nome = "Kleber";

            Console.WriteLine(Pessoa1.Endereco);
            Console.WriteLine(Pessoa1.nome);

            PessoaFisica PF = new PessoaFisica();
        }

    }

}



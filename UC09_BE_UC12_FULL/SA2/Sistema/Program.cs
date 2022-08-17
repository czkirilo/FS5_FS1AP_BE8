
namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"
=================================================== 
!                                                 !          
!                                                 !
!         Seja Bem Vindo ao nosso Sistema         !
!           de Cadastro de Pessoa                 !
!             Fisica e Juridica                   !
!                                                 !
!                                                 !
===================================================               
");

            Console.Write("iniciando ");
            Thread.Sleep(500);

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write("#");
                Thread.Sleep(500);
            }
            Console.Clear();

        string? opcao;

            do
            {
                Console.WriteLine(@$"
=================================================== 
!          Escolha uma das opcoes abaixo          !          
=================================================== 
!              1 - Pessoa Fisica                  !
!              2 - Pessoa Juridica                !
!                                                 !
!              0 - Sair                           !
!                                                 !
===================================================               
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opcao invalida, por favor digite uma das opcoes apresentadas");
                        break;
                }
            } while (opcao != "0");

                        Console.ResetColor();
        }
    }
}

// pagina 5
// auto ident = shift + alt + F
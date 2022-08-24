
namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {

            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write(texto);
                Thread.Sleep(500);

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("$");
                    Thread.Sleep(500);
                }

            }



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
           // BarraCarregamento("Iniciando ");

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
                        Endereco endPf = new Endereco();

                        endPf.logradouro = "Rua Niteroi";
                        endPf.numero = 180;
                        endPf.complemento = "Escola SENAI Paulo Skaf";
                        endPf.enderecoComercial = false;

                        PessoaFisica Lucas = new PessoaFisica();
                        Lucas.cpf = "651683864546";
                        Lucas.dataNascimento = new DateTime(2004, 08, 21);
                        Lucas.endereco = endPf;
                        Lucas.nome = "Lucas Rodriguez Sinni";

                        Console.WriteLine(@$"Nome: {Lucas.nome}
CPF: {Lucas.cpf} 
Nascido em {Lucas.dataNascimento.ToString("dd/MM/yyyy")}
Endereço: {endPf.logradouro}, {endPf.numero}");

                        
                        Console.WriteLine();
                        break;
                    case "2":
                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua Niteroi";
                        endPj.numero = 180;
                        endPj.complemento = "Escola SENAI Paulo Skaf";
                        endPj.enderecoComercial = true;

                        PessoaJuridica pj = new PessoaJuridica();
                        pj.cnpj = "0104115487";
                        pj.endereco = endPj;
                        pj.RazaoSocial = "Pessoa Juridica";
                        pj.nome = "Jequiti";

                        Console.WriteLine(pj.cnpj);
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por utilizar o nosso sistema");
                      //  BarraCarregamento("Finalizando ");

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
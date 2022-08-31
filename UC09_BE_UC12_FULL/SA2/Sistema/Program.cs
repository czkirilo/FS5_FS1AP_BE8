﻿
namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();
            Console.ForegroundColor = ConsoleColor.Green;
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
!                                                 !
!                 PESSOA FISICA                   !
!           1 - Cadastrar Pessoa Física           !
!           2 - Listar Pessoa Física              !
!           3 - Remover Pessoa Física             !
!                                                 !
!                 PESSOA JURIDICA                 !
!           4 - Cadastrar Pessoa Juridica         !
!           5 - Listar Pessoa Juridica            !
!           6 - Remover Pessoa Juridica           !
===================================================
!              0 - Sair                           !
===================================================               
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    //Cadastrar pessoa fisica
                    Endereco endPf = new Endereco();
                    Console.WriteLine("Digite seu logradouro");
                    endPf.logradouro = Console.ReadLine();

                    Console.WriteLine("Digite o Número da sua residencia");
                    endPf.numero = int.Parse(Console.ReadLine());

                    Console.WriteLine(@$"Digite o Complemento da sua resiencia caso exista, senao, pressione ENTER para pular");
                    endPf.complemento  = Console.ReadLine();

                    Console.WriteLine("Este endereço é comercial? (S = SIM / N = Não)");
                    string endComercial = Console.ReadLine().ToUpper();

                    if(endComercial == "S"){
                        endPf.enderecoComercial = true;
                    }else{
                        endPf.enderecoComercial = false;
                    }


                    PessoaFisica pf = new PessoaFisica();
                    pf.endereco = endPf;

                    Console.WriteLine("Digite seu CPF (Somente Numeros)");
                    pf.cpf = Console.ReadLine();

                    Console.WriteLine("Digite seu Nome");
                    pf.nome = Console.ReadLine();

                    Console.WriteLine("Digite o valor do seu salario");
                    pf.salario = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite sua data de aniversario [AA, MM, DD]");
                    pf.dataNascimento = DateTime.Parse(Console.ReadLine());

                    bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

                    if(idadeValida == true){
                        Console.WriteLine("Cadastro Aprovado");
                        listaPf.Add(pf);
                        Console.WriteLine(pf.PagarImposto(pf.salario));
                    }
                        break;
                    case "2":
                    foreach (var cadaItem in listaPf){
                        Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}");
                    }
                        break;
                    case "3":
                    // Remover pessoa fisica
                    Console.WriteLine("Digite o CPF do meliante que deseja remover");
                    string cpfProcurado = Console.ReadLine();
                    PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                    if (pessoaEncontrada != null){
                        listaPf.Remove(pessoaEncontrada);
                        Console.WriteLine("Meliante removido");
                    }else{
                        Console.WriteLine("cpf não encontrado");
                    }

                        break;
                    case "4":
                    //Cadastrar pessoa juridica
                        break;
                    case "5":
                    // Listar pessoa juridica
                        break;
                    case "6":
                    // Remover pessoa juridica
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

// auto ident = shift + alt + F
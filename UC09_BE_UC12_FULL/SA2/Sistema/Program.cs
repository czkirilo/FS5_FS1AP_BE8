
namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PessoaFisica pf = new PessoaFisica();
            pf.endereco = end;
            pf.nome = "Caique Zaneti";
            pf.cpf = "6565151";
            pf.dataNascimento = new DateTime (1994, 05, 19);

        //interpolação
        Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro} numero {pf.endereco.numero}");
        //concatenação
        Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + " número " + pf.endereco.numero
);
        //forma não-inteligente
        Console.WriteLine(pf.endereco.logradouro);
        Console.WriteLine(pf.endereco.numero);
        Console.WriteLine(pf.endereco.complemento);

                
        bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
 
        if (idadeValida == true)
        {
            System.Console.WriteLine("Parabens, você é velho o suficiente para acessar o sistema");
        }else{
            Console.WriteLine("Você ainda assiste felipe neto que eu sei");
        }
    
*/

            PessoaJuridica pj = new PessoaJuridica();
            
            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Qualquer coisa";
            end.enderecoComercial = true;

            pj.endereco = end;
            pj.cnpj = "12345678990001";
            pj.RazaoSocial = "Pessoa Juridica";

            if(pj.ValidarCNPJ(pj.cnpj)){
                Console.WriteLine("cnpj valido");
            }else{
                Console.WriteLine("cnpj invalido");
            }
            





        }
    }
}


// auto ident = shift + alt + F
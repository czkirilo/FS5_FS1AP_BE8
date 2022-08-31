using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }      
        public DateTime dataNascimento { get; set; }
        public float salario { get; set; }
        public override float PagarImposto(float salario){
            if (salario <= 1500)
            {
                return 0;
            }
            else if (salario > 1500 && salario <= 5000)
            {
                return salario * 3 / 100;
            }
            else if (salario > 5000)
            {
                return salario * 5 / 100;
            }else{
                return 0;
            }
        }
       public bool ValidarDataNascimento(DateTime dataNascimento){
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays /365;

            if (anos >= 18){
                return true;
            }else{
                return false;
            }

        }
    }
}
/*

Criar método de pagar imposto para pessoa física e pessoa jurídica que calcule a porcentagem de desconto conforme o rendimento.

Pessoa física
Para rendimentos até R$1.500,00 - isento (desconto 0)
Para rendimentos entre R$1.501,00 e R$5.000,00 - desconto de 3%
Para rendimentos acima de R$5.000,01 - desconto de 5%

Pessoa jurídico
Para rendimentos até R$5.000,00- desconto de 6%
Para rendimentos entre R$5.001,00 e R$10.000,00 - desconto de 8%
Para rendimentos acima de R$10.000,01 - desconto de 10%

OBS. O método deve retornar o valor do desconto e não mostrar direto na tela.


*/
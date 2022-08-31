using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        
        public string RazaoSocial { get; set; }
        
        public override float PagarImposto(float rendimento){
            float imposto = 0;

            if (rendimento <= 5000)
            {
                imposto = rendimento * 6 / 100;
            }
            else if (rendimento > 5000 && rendimento <= 10000)
            {
                imposto = rendimento * 8 / 100;
            }
            else 
            {
                imposto = rendimento * 10 / 100;
            }

            return imposto;
        }

        public bool ValidarCNPJ(string cnpj){
            if(cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length - 4)) == "0001"){
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
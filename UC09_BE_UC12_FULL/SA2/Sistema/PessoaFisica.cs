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
        public override void PagarImposto(float rendimento){}
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public DateTime dataNascimento { get; set; }

    }
}
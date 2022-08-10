using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class  Pessoa
    {
        //Atributos
        public string nome { get; set; }
        public Endereco endereco { get; set; }  

        //Métodos
        public abstract void PagarImposto(float rendimento);
    }
}
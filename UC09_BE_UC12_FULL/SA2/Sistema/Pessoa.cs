using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class Pessoa
    {
        //Atributos
        public string? nome { get; set; }
        public string? Endereco { get; set; }       
        public bool enderecoComercial { get; set; }
        
        //Métodos
        public void PagarImposto(){}
    }
}
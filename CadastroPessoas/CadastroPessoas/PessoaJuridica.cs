using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoas
{
    public class PessoaJuridica : Pessoa
    {
        private string _CNPJ;

        public string CNPJ { get => _CNPJ; set => _CNPJ = value; }

        public PessoaJuridica()
        {

        }
    }
}

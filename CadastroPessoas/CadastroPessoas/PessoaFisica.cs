using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoas
{
    public class PessoaFisica : Pessoa
    {
        private string _CPF;

        public string CPF { get => _CPF; set => _CPF = value; }

        public PessoaFisica()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoas
{
    public class Pessoa
    {
        private string _Nome;
        private string _SobreNome;
        private int _Idade;
        private string _Telefone;        

        public string Nome { get => _Nome; set => _Nome = value; }
        public string SobreNome { get => _SobreNome; set => _SobreNome = value; }
        public int Idade { get => _Idade; set => _Idade = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }        

        public Pessoa()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoas
{
    public interface IBancoDados
    {
        void CriarBancoDados();
        void ExcluirBancoDados();
        void CadastrarPessoa(PessoaJuridica p);
        void CadastrarPessoa(PessoaFisica p);
        void ListarTodos();
        bool VerificaSeClienteExiste(string documento);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CadastroPessoas
{
    public class BancoDados : IBancoDados
    {
        private const string caminhoBancoDados = @"C:\Users\thiag\Desktop\CadastroPessoas\CadastroPessoas\BancoDados.txt";

        public void CriarBancoDados()
        {
            try
            {
                Console.WriteLine("Tentando criar o banco de dados\n");
                if (File.Exists(caminhoBancoDados))                    
                    Console.WriteLine("Banco de dados já existe\n");
                else
                {
                    Console.WriteLine("Banco de dados criado\n");
                    File.Create(caminhoBancoDados).Close();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw ex;
            }
            
        }

        public void ExcluirBancoDados()
        {
            try
            {
                Console.WriteLine("Tentando excluir o banco de dados\n");
                if (!File.Exists(caminhoBancoDados))
                    Console.WriteLine("Banco de dados já foi excluído\n");
                else
                {
                    Console.WriteLine("Banco de dados excluído\n");
                    File.Delete(caminhoBancoDados);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw ex;
            }
        }

        public void CadastrarPessoa (PessoaJuridica p)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(caminhoBancoDados, true))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Inserindo pessoa jurídica no banco de dados\n");
                    string pessoa = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t", p.Nome, p.SobreNome, p.CNPJ, p.Idade, p.Telefone);
                    streamWriter.WriteLine(pessoa);
                    Console.WriteLine("Pessoa jurídica inserida com sucesso\n");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw ex;
            }            
        }

        public void CadastrarPessoa(PessoaFisica p)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(caminhoBancoDados, true))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Inserindo pessoa física no banco de dados\n");
                    string pessoa = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t", p.Nome, p.SobreNome, p.CPF, p.Idade, p.Telefone);
                    streamWriter.WriteLine(pessoa);
                    Console.WriteLine("Pessoa física inserida com sucesso\n");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw ex;
            }
        }

        public void ListarTodos()
        {
            try
            {
                if (File.Exists(caminhoBancoDados))
                {
                    using (TextReader textReader = new StreamReader(caminhoBancoDados))
                    {
                        Console.WriteLine(textReader.ReadToEnd());
                        Console.WriteLine("Fim do arquivo\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw ex;
            }
        }

        public bool VerificaSeClienteExiste(string documento)
        {
            try
            {
                if(File.Exists(caminhoBancoDados))
                {
                    using (TextReader textReader = new StreamReader(caminhoBancoDados))
                    {
                        return textReader.ReadToEnd().ToLower().Contains(documento.ToLower());
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw ex;
            }
        }
    }
}

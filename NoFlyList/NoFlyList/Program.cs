using System;
using System.IO;

namespace NoFlyList
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\Users\thiag\Desktop\NoFlyList\NoFlyList\NoFly.txt";

            CriarArquivo(caminhoArquivo);

            InserirDados(caminhoArquivo);

            if(VerificarNome(caminhoArquivo))
                Console.WriteLine("Essa pessoa é suspeita\n");
            else
                Console.WriteLine("Essa pessoa não é suspeita\n");
        }

        static void CriarArquivo(string caminhoArquivo)
        {
            try
            {

                if (!File.Exists(caminhoArquivo))
                    File.Create(caminhoArquivo).Close();
                else
                    Console.WriteLine("Arquivo já existe\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw ex;
            }           
        }

        static void InserirDados(string caminhoArquivo)
        {
            try
            {
                string nome;
                char escolha;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Digite o nome que você deseja inserir no arquivo\n");
                    nome = Console.ReadLine();

                    using (StreamWriter streamWriter = new StreamWriter(caminhoArquivo, true))
                    {
                        streamWriter.WriteLine(nome);
                    }

                    Console.WriteLine("Deseja inserir outro nome ?\n");
                    escolha = char.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();
                } while (escolha == 's');
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro -> {0}", ex.Message);
                throw;
            }
        }

        static bool VerificarNome(string caminhoArquivo)
        {
            string nome;
            string [] listaNomes;
            int indice = 0;
            int quantidadeNomes;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Qual nome você deseja verificar ?\n");
            nome = Console.ReadLine();
            listaNomes = File.ReadAllLines(caminhoArquivo);
            quantidadeNomes = listaNomes.Length;
            Console.ResetColor();
            while(indice < quantidadeNomes)
            {
                if (listaNomes[indice].Equals(nome))
                    return true;
                indice = indice + 1;
            }

            return false;
        }
    }
}

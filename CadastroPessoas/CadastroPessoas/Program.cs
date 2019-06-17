using System;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            int menuEscolha;
            IBancoDados bancoDados = new BancoDados();

            bancoDados.CriarBancoDados();

            do
            {
                Console.WriteLine("Escolha o que deseja fazer\n");
                Console.WriteLine("1 - Listar todos os clientes\n");
                Console.WriteLine("2 - Verificar se cliente já está cadastrado\n");
                Console.WriteLine("3 - Cadastrar cliente jurídico\n");
                Console.WriteLine("4 - Cadastrar cliente físico\n");
                Console.WriteLine("5 - Excluir banco de dados\n");
                menuEscolha = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch(menuEscolha)
                {
                    case 1:
                        Console.WriteLine("Listando todos os clientes\n");
                        bancoDados.ListarTodos();
                        break;

                    case 2:
                        string documento;                        
                        Console.WriteLine("Digite o número do documento da pessoa\n");
                        documento = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Verificando se cliente já está cadastrado\n");
                        if(bancoDados.VerificaSeClienteExiste(documento))
                            Console.WriteLine("Cliente já está cadastrado\n");
                        else
                            Console.WriteLine("Cliente não encontrado\n");
                        Console.ResetColor();

                        break;

                    case 3:
                        Console.WriteLine("Cadastrando cliente jurídico\n");
                        PessoaJuridica pj = new PessoaJuridica();
                        Console.WriteLine("Digite o nome da pessoa\n");
                        pj.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do(a) {0}\n", pj.Nome);
                        pj.SobreNome = Console.ReadLine();
                        Console.WriteLine("Digite o CNPJ do(a) {0}\n", pj.Nome);
                        pj.CNPJ = Console.ReadLine();
                        Console.WriteLine("Digite a idade do(a) {0}\n", pj.Nome);
                        pj.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o telefone do(a) {0}\n", pj.Nome);
                        pj.Telefone = Console.ReadLine();
                        Console.WriteLine("\n");
                        bancoDados.CadastrarPessoa(pj);
                        break;

                    case 4:
                        Console.WriteLine("Cadastrando cliente físico\n");
                        PessoaFisica pf = new PessoaFisica();
                        Console.WriteLine("Digite o nome da pessoa\n");
                        pf.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do(a) {0}\n",pf.Nome);
                        pf.SobreNome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do(a) {0}\n", pf.Nome);
                        pf.CPF = Console.ReadLine();
                        Console.WriteLine("Digite a idade do(a) {0}\n", pf.Nome);
                        pf.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o telefone do(a) {0}\n", pf.Nome);
                        pf.Telefone = Console.ReadLine();
                        Console.WriteLine("\n");
                        bancoDados.CadastrarPessoa(pf);
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Excluindo banco de dados\n");
                        bancoDados.ExcluirBancoDados();
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("Opção inválida\n");
                        break;
                }
                Console.WriteLine("Deseja continuar no programa ?\n");
                escolha = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("\n");
            } while (escolha == 's');
        }
    }
}

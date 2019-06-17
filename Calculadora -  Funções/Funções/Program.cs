using System;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Digite o valor do número 1\n");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do número 2\n");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma de {0} e {1} é igual a {2}\n", numero1,numero2, soma(numero1, numero2));
            Console.WriteLine("A subtração de {0} e {1} é igual a {2}\n", numero1, numero2, subtrai(numero1, numero2));
            Console.WriteLine("A multiplicação de {0} e {1} é igual a {2}\n", numero1, numero2, multiplica(numero1, numero2));
            Console.WriteLine("A divisão de {0} e {1} é igual a {2}\n", numero1, numero2, divide(numero1, numero2));
        }

        static int soma(int n1, int n2)
        {
            return n1 + n2;
        }

        static int subtrai(int n1, int n2)
        {
            return n1 - n2;
        }

        static int multiplica(int n1, int n2)
        {
            return n1 * n2;
        }

        static int divide(int n1, int n2)
        {
            if (n2 > 0)
                return n1 / n2;
            else
            {
                Console.WriteLine("Não existe divisão por 0");
                return 0;
            }
        }
    }
}

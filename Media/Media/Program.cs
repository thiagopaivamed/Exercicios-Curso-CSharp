using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0.0;
            int numero, quantidadeNumeros = 0;
            char escolha;

            do
            {
                Console.WriteLine("Digite um número\n");
                numero = int.Parse(Console.ReadLine());
                media = media + numero;
                quantidadeNumeros = quantidadeNumeros + 1;
                Console.WriteLine("A média por enquanto possuí o valor de {0}\n", media / quantidadeNumeros);
                Console.WriteLine("Deseja continuar digitando os números ? \n");
                escolha = char.Parse(Console.ReadLine().ToLower());
            } while (escolha == 's');
        }
    }
}

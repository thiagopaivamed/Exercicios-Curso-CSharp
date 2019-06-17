using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            double media = 0.0;
            int qtd;

            for(qtd = 0; qtd < numeros.Length; qtd ++)
            {
                Console.WriteLine("Digite o número {0}", qtd);
                numeros[qtd] = int.Parse(Console.ReadLine());
            }

            for (qtd = 0; qtd < numeros.Length; qtd++)
            {
                media = media + numeros[qtd];
            }

            Console.WriteLine("O resultado da média é {0}", media / numeros.Length);
        }
    }
}

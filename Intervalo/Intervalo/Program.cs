using System;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim;

            Console.WriteLine("Digite o valor inicial do intervalo");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor final do intervalo");
            fim = int.Parse(Console.ReadLine());

            if(inicio < fim)
            {
                Console.WriteLine("O intervalo entre os valores {0} e {1} é\n", inicio, fim);
                for(; inicio <=fim; inicio++)
                {
                    Console.WriteLine("{0}\t",inicio);
                }
            }
            else
                Console.WriteLine("Valores inválidos");
        }
    }
}

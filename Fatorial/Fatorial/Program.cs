using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 1, numero;

            Console.WriteLine("Digite o número a ser calculado do fatorial");
            numero = int.Parse(Console.ReadLine());

            if(numero < 0)
                Console.WriteLine("Número inválido");
            else if (numero == 0 || numero == 1)
                Console.WriteLine("O resultado do fatorial de {0} é {1}", numero, resultado);
            else
            {
                Console.WriteLine("O resultado do fatorial de {0} é ", numero);
                while (numero >= 2)
                {
                    resultado = resultado * numero;
                    numero = numero - 1;
                }

                Console.WriteLine("{0}", resultado);
            }
        }
    }
}

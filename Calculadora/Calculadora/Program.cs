using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Digite o valor do número 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do número 2");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor {0} somado com {1} é igual a {2}", numero1, numero2, numero1 + numero2);
            Console.WriteLine("O valor {0} subtraído de {1} é igual a {2}", numero1, numero2, numero1 - numero2);
            Console.WriteLine("O valor {0} multiplicado por {1} é igual a {2}", numero1, numero2, numero1 * numero2);
            Console.WriteLine("O valor {0} dividido por {1} é igual a {2}", numero1, numero2, numero1 / numero2);
        }
    }
}

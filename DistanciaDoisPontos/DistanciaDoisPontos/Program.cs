using System;

namespace DistanciaDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;

            Console.WriteLine("Informe o valor de x1\n");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de y1\n");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de x2\n");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de y2\n");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A distância entre os pontos P1 ( {0}, {1} ) e P2 ( {2}, {3} ) é igual a {4}", x1, y1, x2, y2, Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        }
    }
}

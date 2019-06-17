using System;

namespace MegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1 = 36, d2 = 60, d3 = 12, d4 = 25, d5 = 10, d6 = 29;
            int dezena1, dezena2, dezena3, dezena4, dezena5, dezena6;

            Console.WriteLine("É sua hora de jogar ! \n");
            Console.WriteLine("Digite o valor da dezena 1\n");
            dezena1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da dezena 2\n");
            dezena2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da dezena 3\n");
            dezena3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da dezena 4\n");
            dezena4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da dezena 5\n");
            dezena5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da dezena 6\n");
            dezena6 = int.Parse(Console.ReadLine());

            if(dezena1 != d1 && dezena1 != d2 && dezena1 != d3 && dezena1 != d4 && dezena1 != d5 && dezena1 != d6)
                Console.WriteLine("Você perdeu \n");
            else if (dezena2 != d1 && dezena2 != d2 && dezena2 != d3 && dezena2 != d4 && dezena2 != d5 && dezena2 != d6)
                Console.WriteLine("Você perdeu \n");
            else if (dezena3 != d1 && dezena3 != d2 && dezena3 != d3 && dezena3 != d4 && dezena3 != d5 && dezena3 != d6)
                Console.WriteLine("Você perdeu \n");
            else if (dezena4 != d1 && dezena4 != d2 && dezena4 != d3 && dezena4 != d4 && dezena4 != d5 && dezena4 != d6)
                Console.WriteLine("Você perdeu \n");
            else if (dezena5 != d1 && dezena5 != d2 && dezena5 != d3 && dezena5 != d4 && dezena5 != d5 && dezena5 != d6)
                Console.WriteLine("Você perdeu \n");
            else if (dezena6 != d1 && dezena6 != d2 && dezena6 != d3 && dezena6 != d4 && dezena6 != d5 && dezena6 != d6)
                Console.WriteLine("Você perdeu \n");
            else
                Console.WriteLine("Parabéns ! Você ganhou o prêmio da mega sena !!! \n");
        }
    }
}

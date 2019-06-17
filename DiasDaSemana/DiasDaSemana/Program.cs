using System;

namespace DiasDaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            Console.WriteLine("Escolha o dia da semana a ser exibido\n");
            Console.WriteLine("1 - Domingo\n");
            Console.WriteLine("2 - Segunda-feira\n");
            Console.WriteLine("3 - Terça-feira\n");
            Console.WriteLine("4 - Quarta-feira\n");
            Console.WriteLine("5 - Quinta-feira\n");
            Console.WriteLine("6 - Sexta-feira\n");
            Console.WriteLine("7 - Sábado\n");
            escolha = int.Parse(Console.ReadLine());

            if(escolha == 1)
                Console.WriteLine("Domingo");
            else if(escolha == 2)
                Console.WriteLine("Segunda-feira");
            else if (escolha == 3)
                Console.WriteLine("Terça-feira");
            else if (escolha == 4)
                Console.WriteLine("Quarta-feira");
            else if (escolha == 5)
                Console.WriteLine("Quinta-feira");
            else if (escolha == 6)
                Console.WriteLine("Sexta-feira");
            else if (escolha == 7)
                Console.WriteLine("Sábado");
            else
                Console.WriteLine("Número inválido\n");

        }
    }
}

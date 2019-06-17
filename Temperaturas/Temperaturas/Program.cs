using System;

namespace Temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura;
            int escolha;

            Console.WriteLine("Escolha a conversão a ser feita\n");
            Console.WriteLine("1 - Farenheit para Célsius\n");
            Console.WriteLine("2 - Célsius para Farenheit\n");
            Console.WriteLine("3 - Kelvin para Célsius\n");
            Console.WriteLine("4 - Célsius para Kelvin\n");
            escolha = int.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Farenheit\n");
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine("A temperatura {0} convertida é igual a {1}", temperatura, (temperatura - 32) / 1.8);
                    break;

                case 2:
                    Console.WriteLine("Digite a temperatura em Célsius\n");
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine("A temperatura {0} convertida é igual a {1}", temperatura, (1.8 * temperatura) + 32);
                    break;

                case 3:
                    Console.WriteLine("Digite a temperatura em Kelvin\n");
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine("A temperatura {0} convertida é igual a {1}", temperatura, 273 - temperatura);
                    break;

                case 4:
                    Console.WriteLine("Digite a temperatura em Célsius\n");
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine("A temperatura {0} convertida é igual a {1}", temperatura, temperatura + 273);
                    break;

                default:
                    Console.WriteLine("Opção inválida\n");
                    break;
            }
        }
    }
}

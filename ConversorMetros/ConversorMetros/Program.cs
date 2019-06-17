using System;

namespace ConversorMetros
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros;
            int escolha;

            Console.WriteLine("Digite a conversão que você quer\n");
            Console.WriteLine("1 - Metro para quilômetro\n");
            Console.WriteLine("2 - Metro para milímetro\n");
            escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os metros\n");
            metros = double.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("{0} metros é igual a {1} quilômetros", metros, metros / 1000);
                    break;

                case 2:
                    Console.WriteLine("{0} metros é igual a {1} milímetros", metros, metros * 1000);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
           
        }
    }
}

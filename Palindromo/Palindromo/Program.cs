using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            bool palindromo = true;
            int inicio, fim;

            Console.WriteLine("Digite a palavra\n");
            palavra = Console.ReadLine();

            for(inicio = 0, fim = palavra.Length - 1; inicio < palavra.Length; inicio++, fim--)
            {
                if (palavra[inicio] != palavra[fim])
                    palindromo = false;
            }

            if(palindromo == false)
                Console.WriteLine("A palavra {0} não é um palíndromo\n", palavra);
            else
                Console.WriteLine("A palavra {0} é um palíndromo\n", palavra);
        }
    }
}

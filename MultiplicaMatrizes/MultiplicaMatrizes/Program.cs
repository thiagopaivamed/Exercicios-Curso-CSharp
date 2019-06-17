using System;

namespace MultiplicaMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int coluna, linha;

            Console.WriteLine("Preenchimento da matriz A\n");
            Console.ForegroundColor = ConsoleColor.Blue;

            for(linha = 0; linha < 2; linha ++)
            {
                for(coluna = 0; coluna < 2; coluna ++)
                {
                    Console.WriteLine("Digite o valor da coluna {0} linha {1}\n", coluna, linha);
                    matrizA[coluna, linha] = int.Parse(Console.ReadLine());
                }
            }

            Console.ResetColor();
            Console.WriteLine("Preenchimento da matriz B\n");
            Console.ForegroundColor = ConsoleColor.Green;

            for (linha = 0; linha < 2; linha++)
            {
                for (coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine("Digite o valor da coluna {0} linha {1}\n", coluna, linha);
                    matrizB[coluna, linha] = int.Parse(Console.ReadLine());
                }
            }

            Console.ResetColor();
            Console.WriteLine("Resultado da multiplicação de matrizes \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Linha 0 Coluna 0 -> {0}", matrizA[0, 0] * matrizB[0, 0] + matrizA[0, 1] * matrizB[1, 0]);
            Console.WriteLine("Linha 0 Coluna 1 -> {0}", matrizA[0, 0] * matrizB[0, 1] + matrizA[0, 1] * matrizB[1, 1]);
            Console.WriteLine("Linha 1 Coluna 0 -> {0}", matrizA[1, 0] * matrizB[0, 0] + matrizA[1, 1] * matrizB[0, 1]);
            Console.WriteLine("Linha 1 Coluna 1 -> {0}", matrizA[1, 0] * matrizB[0, 1] + matrizA[1, 1] * matrizB[1, 1]);
        }
    }
}

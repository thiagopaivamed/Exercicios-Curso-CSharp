using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int escolhaParImpar, numeroJogadaComputador, numeroJogadaUsuario, numeroComputadorVencedor = 0, numeroUsuarioVencedor = 0;

            try
            {
                do
                {
                    Console.WriteLine("Você quer par ou impar ?\n");
                    Console.WriteLine("0 - Par\n");
                    Console.WriteLine("1 - Impar\n");
                    escolhaParImpar = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    if (escolhaParImpar == 0)
                    {
                        numeroJogadaComputador = new Random().Next(0, 100);
                        Console.WriteLine("Faça a sua jogada\n");
                        numeroJogadaUsuario = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");

                        if ((numeroJogadaUsuario + numeroJogadaComputador) % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou o número {0}\n", numeroJogadaUsuario);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("O computador jogou o número {0}\n", numeroJogadaComputador);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. Você ganhou !!!\n", numeroJogadaUsuario + numeroJogadaComputador);
                            Console.ResetColor();
                            numeroUsuarioVencedor = numeroUsuarioVencedor + 1;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou o número {0}\n", numeroJogadaUsuario);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("O computador jogou o número {0}\n", numeroJogadaComputador);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. O computador ganhou !!!\n", numeroJogadaUsuario + numeroJogadaComputador);
                            Console.ResetColor();
                            numeroComputadorVencedor = numeroComputadorVencedor + 1;
                        }
                    }

                    else if (escolhaParImpar == 1)
                    {
                        numeroJogadaComputador = new Random().Next(0, 100);
                        Console.WriteLine("Faça a sua jogada\n");
                        numeroJogadaUsuario = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");

                        if ((numeroJogadaUsuario + numeroJogadaComputador) % 2 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou o número {0}\n", numeroJogadaUsuario);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("O computador jogou o número {0}\n", numeroJogadaComputador);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. Você ganhou !!!\n", numeroJogadaUsuario + numeroJogadaComputador);
                            Console.ResetColor();
                            numeroUsuarioVencedor = numeroUsuarioVencedor + 1;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou o número {0}\n", numeroJogadaUsuario);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("O computador jogou o número {0}\n", numeroJogadaComputador);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. O computador ganhou !!!\n", numeroJogadaUsuario + numeroJogadaComputador);
                            Console.ResetColor();
                            numeroComputadorVencedor = numeroComputadorVencedor + 1;
                        }
                    }

                    else
                        Console.WriteLine("Escolha inválida\n");

                    Console.WriteLine("Deseja continuar jogando ? \n");
                    continuar = char.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine("\n");

                } while (continuar == 's');                
            }

            catch (Exception ex)
            {
                Console.WriteLine("O programa teve um erro - {0}", ex.Message);
                throw ex;
            }

            finally
            {
                Console.WriteLine("Você venceu {0} vezes.\n", numeroUsuarioVencedor);
                Console.WriteLine("O computador venceu {0} vezes.\n", numeroComputadorVencedor);
            }
        }
    }
}

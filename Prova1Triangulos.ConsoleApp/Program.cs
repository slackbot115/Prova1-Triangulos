using System;

namespace Prova1Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA = 0, ladoB = 0, ladoC = 0;
            while (true)
            {
                Console.WriteLine("1 para verificação de um triângulo\n0 para sair");
                try
                {
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Clear();
                        Console.Write("Digite o primeiro lado: ");
                        ladoA = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo lado: ");
                        ladoB = int.Parse(Console.ReadLine());
                        Console.Write("Digite o terceiro lado: ");
                        ladoC = int.Parse(Console.ReadLine());

                        if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
                        {
                            if (ladoA == ladoB && ladoB == ladoC)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("O triângulo é equilátero!\n");
                                Console.ResetColor();
                            }
                            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nO triângulo é isósceles!\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nO triângulo é escaleno!\n");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nTriângulo inválido...\n");
                            Console.ResetColor();
                        }
                    }
                    else if (op == 0)
                    {
                        Console.WriteLine("\nFechando o programa...");
                        break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpção inválida, digite novamente...");
                    Console.ResetColor();
                }
            }
        }
    }
}

using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            Console.WriteLine("------------------");
            Console.WriteLine("Calculadora");
            Console.WriteLine("------------------");         

            try
            {
                while (continuar)
                {
                    Console.WriteLine("Digite o primeiro número:");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número:");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Selecione uma opção:");

                    Console.WriteLine("+");
                    Console.WriteLine("-");
                    Console.WriteLine("*");
                    Console.WriteLine("/");

                    int resultado = 0;

                    switch (Console.ReadLine())
                    {
                        case "+":
                            resultado = num1 + num2;
                            Console.WriteLine($"Seu resultado: {num1} + {num2} = {resultado}");
                            break;
                        case "-":
                            resultado = num1 - num2;
                            Console.WriteLine($"Seu resultado: {num1} - {num2} = {resultado}");
                            break;
                        case "*":
                            resultado = num1 * num2;
                            Console.WriteLine($"Seu resultado: {num1} * {num2} = {resultado}");
                            break;
                        case "/":
                            resultado = num1 / num2;
                            Console.WriteLine($"Seu resultado: {num1} / {num2} = {resultado}");
                            break;
                    }

                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Gostaria de realizar outra operação?");
                    Console.WriteLine("S = Sim, N = Não");

                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        continuar = true;
                    }
                    else
                    {
                        continuar = false;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Você não pode dividir um número por zero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Verifique os valores informados e tente de novo.");
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("Obrigado por utilizar!");

            Console.ReadLine();
        }
    }
}

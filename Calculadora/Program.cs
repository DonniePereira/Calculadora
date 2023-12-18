using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando uma variável que determinará o inicio, ou o fim do programa
            bool continuar = true;       

            Console.WriteLine("------------------");
            Console.WriteLine("Calculadora");
            Console.WriteLine("------------------");         

            try
            {
                while (continuar)
                {
                    // Pedindo ao usuário informar 2 números e para que ele selecione a operação que irá realizar
                    Console.WriteLine("Digite o primeiro número:");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número:");
                    double num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Selecione a operação que deseja realizar:");

                    Console.WriteLine("+");
                    Console.WriteLine("-");
                    Console.WriteLine("*");
                    Console.WriteLine("/");

                    // declarando uma variável para armazernar o resultado da operação escolhida dentro do switch
                    double resultado = 0;

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
                            if(num2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            resultado = num1 / num2;
                            Console.WriteLine($"Seu resultado: {num1} / {num2} = {resultado}");
                            break;                        
                    }

                    // Perguntando ao usuário se ele deseja realizar outra operação, ou se deseja sair
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Gostaria de realizar outra operação?");
                    Console.WriteLine("S = Sim, N = Não");

                    // Se ele escolher (sim) o programa será executado de novo, se escolher (não) o looping irá terminar
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
            // Capturando uma possível tentativa de divisão por zero
            catch (DivideByZeroException)
            {
                Console.WriteLine("Você não pode dividir um número por zero!");
            }
            // Capturando uma excessão genérica
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

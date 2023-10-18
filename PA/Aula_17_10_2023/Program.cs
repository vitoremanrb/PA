using System;

namespace Aula_17_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float Num1, Num2, resultado;
            string operador;

            Console.Write("Digite o 1º número: ");
            Num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            Num2 = float.Parse(Console.ReadLine());

            Console.Write("Qual o operador matemático? ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    resultado = Num1 + Num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "-":
                    resultado = Num1 - Num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "*":
                    resultado = Num1 * Num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "/":
                    resultado = Num1 / Num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    break;
            }
        }
    }
}

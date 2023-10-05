using System;

namespace Exercício_1_05_10_2023
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

            if (operador == "+")
            {
                resultado = Num1 + Num2;
                Console.WriteLine($"O resultado da soma dos números é: {resultado} ");
            }
            else if (operador == "-")
            {
                resultado = Num1 - Num2;
                Console.WriteLine($"O resultado da subtração será: {resultado} ");
            }
            else if (operador == "*")
            {
                resultado = Num1 * Num2;
                Console.WriteLine($"O resultado da multiplicação será: {resultado} ");
            }
            else
            {
                resultado = Num1 / Num2;
                Console.WriteLine($"O resultado da divisão será: {resultado} ");
            }
        }
    }
}

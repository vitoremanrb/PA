using System;

namespace Exercício___3_05_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, reajuste_Sal;

            Console.Write("Informe o salário do funcionário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 3000)
                Console.Write($"O reajuste salarial será de 50%");

            else if (salario <= 7000)
                Console.Write("O reajuste salarial será de 20%");

            else if (salario <= 10000)
                Console.Write("O reajuste salarial será de 15%");

            else
                Console.Write("O reajuste salarial será de 10%");
        }
    }
}

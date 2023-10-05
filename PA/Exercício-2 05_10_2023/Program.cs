using System;

namespace Exercício_2_05_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float Num;

            Console.Write("Informe o número desejado: ");
            Num = float.Parse(Console.ReadLine());

            if (Num > 10)
                Console.Write("O número informado é maior que 10!");
            else
                Console.Write("O número informado é menor que 10!");
        }
    }
}

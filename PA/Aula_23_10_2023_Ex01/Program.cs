﻿using System;

namespace Aula_23_10_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            do
            {
                Console.WriteLine($"2 x {contador} = {2 * contador} ");
                //contador = contador + 1;
                contador++;
            } while (contador <= 10);

            Console.WriteLine("Fim da tabuada");

        }
    }
}

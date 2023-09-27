using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, soma, media, percFreq;

            Console.Write("Informe a 1º Nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 2º Nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 3º Nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 4º Nota: ");
            nota4 = float.Parse(Console.ReadLine());

            Console.Write("Informe o percentual de frequência do aluno(A)");
            percFreq = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;

            media = soma / 4;

            //0.00 a 4.99 e % de frequência <= 40 - Reprovado
            //5.00 a 6.99 e % de frequência <= 60 - Recuperação
            //7.00 a 10   e % de frequência > 60 - Aprovado

            if(media < 5 && percFreq <= 40)
            {
                Console.WriteLine("Reprovado!");
                Console.Write("Se esforce mais!");
            }
            else if(media <= 7 && percFreq <= 60)
            {
                Console.WriteLine("Você está de recuperação!");
                Console.Write("Se esforce mais, você consegue!");
            }
            else if(media <= 10 && percFreq > 60)
            {
                Console.WriteLine("Você está aprovado!");
                Console.Write("PARABÉNS");
            }
            else
            {
                Console.WriteLine("Será analisado pela secretaria acadêmica");
            }

        }
    }
}

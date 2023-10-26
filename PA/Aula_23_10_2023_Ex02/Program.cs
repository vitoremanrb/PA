using System;

namespace Aula_23_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            float valorFinanciado, valorParcela;
            int qtdeParcela, contador = 1;

            Console.Write("Informe o valor financiado: ");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de parcelas desejadas: ");
            qtdeParcela = int.Parse(Console.ReadLine());

            //Para esse exemplo de financiamento, a criação de uma variável te possibilita ter mais agilidade e menos uso de CPU.
            valorParcela = valorFinanciado / qtdeParcela;

            DateTime data = DateTime.Now.Date;

            while (contador <= qtdeParcela)
            {
                //Console.WriteLine($"Valor da parcela {contador}, é de {valorFinanciado / qtdeParcela}");
                Console.WriteLine($"{contador}ª parcela ({data}): {valorParcela:0.00}");
                contador++;
                data = data.AddMonths(1);
            }

            Console.WriteLine("Esse será o valor de suas parcelas");

        }
    }
}

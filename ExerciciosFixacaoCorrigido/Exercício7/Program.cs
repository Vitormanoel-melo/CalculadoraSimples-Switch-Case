using System;

namespace Exercício7
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] number = new double[16];

            for (var i = 1; i <= 15; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                number[i] = double.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            for (var n = 15; n > 0; n--)
            {
                Console.WriteLine(number[n]);
            }

        }
    }
}

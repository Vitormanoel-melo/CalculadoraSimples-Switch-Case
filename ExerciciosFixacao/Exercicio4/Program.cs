using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[4];

            for (var i = 0; i < numero.Length; i++)
            {
                Console.Write("Digite um número: ");
                numero[i] = double.Parse(Console.ReadLine());
            }


        }
    }
}

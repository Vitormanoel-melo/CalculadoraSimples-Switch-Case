using System;

namespace Exercicio5
{
    class Program
    {

        static void Main(string[] args)
        {

            int resultado = 0;


            for (var i = 1; i <= 10; i++)
            {   
                Console.WriteLine($"Tabuada do {i} \n");
                for (var a = 1; a <= 10; a++)
                {
                    resultado = i * a;
                    Console.ForegroundColor =  ConsoleColor.Blue;
                    Console.WriteLine($"{i} * {a} = {resultado} \n");
                    System.Threading.Thread.Sleep(250);
                    Console.ResetColor();
                }
                
            }
        }
    }
}

using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int nota = 0;

            do{
                Console.Write("Digite uma nota de 0 a 10: ");
                nota = int.Parse(Console.ReadLine());

                if(nota< 0 || nota > 10){
                    Console.WriteLine("Nota inválida");
                }
            }while(nota < 0 || nota > 10);

            Console.WriteLine("Nota aceita");
        }
    }
}

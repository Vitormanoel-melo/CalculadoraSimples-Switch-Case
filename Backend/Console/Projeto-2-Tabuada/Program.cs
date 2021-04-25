using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
                
            Console.WriteLine("Você deseja ver a tabuada de qual número? ");
            int resposta = int.Parse(Console.ReadLine());


            int resultado;


            for (int contador = 0; contador <=10; contador++){
            

                resultado = resposta * contador;
                Console.WriteLine( $" {resposta} * {contador} = {resultado}" );
            
                System.Threading.Thread.Sleep(500);
                
            }

        }
    }
}

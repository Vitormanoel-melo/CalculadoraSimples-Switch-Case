using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Digite um valor:");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor de Dolar para real: " + Conversor.ConverterDolarParaReal());

            Console.WriteLine("Valor Real para Dolar: " + Conversor.ConverterRealParaDolar().ToString());

            Console.WriteLine("Valor de Euro para Real: " + Conversor.ConverterEuroParaReal() );

            Console.WriteLine("Valor de Real para Euro: " + Conversor.ConverterRealParaEuro());


        }
    }
}

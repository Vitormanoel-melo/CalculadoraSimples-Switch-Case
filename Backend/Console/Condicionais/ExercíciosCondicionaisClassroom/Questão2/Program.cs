using System;

namespace Questão2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Vamos começar!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite seu ano de nascimento: ");
            int nasc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            int atual = int.Parse(Console.ReadLine());

            int idade = atual - nasc;
            int semanas = 52 * idade;

            Console.WriteLine("Sua idade em anos é: " + idade + "anos" );
            Console.WriteLine("Sua idade em semanas é: " + semanas + " semanas");

        }
    }
}

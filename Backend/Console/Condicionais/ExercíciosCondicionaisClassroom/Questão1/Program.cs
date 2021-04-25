using System;

namespace Questão1
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Olá! Bem vindo ao conversor de idade");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Você quer converter sua idade em Meses, dias, horas ou minutos?");
            string conversao = Console.ReadLine();

            int meses = idade * 12;
            int dias = idade * 365;
            int horas = idade * 8760;
            int minutos = idade * 525600;

            if(conversao == "Meses"){
                Console.WriteLine("Sua idade em meses é: " + meses + " meses");
            }

            if(conversao == "Dias"){
                Console.WriteLine( "Sua idade em dias é: " + dias + " dias");
            }
            if(conversao =="Horas"){
                Console.WriteLine( "Sua idade em horas é: " + horas + " horas");
            }
            if(conversao == "Minutos")
                Console.WriteLine( "Sua idade em minutos é: " + minutos + " minutos");
        }
    }
}

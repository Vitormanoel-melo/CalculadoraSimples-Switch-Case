using System;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vamos começar!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite o valor do seu salário em reais (Apenas números): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double valor = double.Parse(Console.ReadLine());
            double aumento = (valor * 30) / 100 ;

            if(valor >= 500){
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Você não tem direito ao aumento de salário!");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Seu salário teve um aumento de 30%, e agora o valor é: " + (aumento + valor) + " reais");
            }
        }
    }
}

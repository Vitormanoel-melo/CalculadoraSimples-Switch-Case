using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja realizar? \nSoma, Subtração, Multiplicação, Divisão");
            string operacao = Console.ReadLine().ToLower(); 

            Console.WriteLine("Digite o 1° número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch(operacao){
                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtração":
                    resultado = num1 - num2;
                    break;

                case "multiplicação":
                    resultado = num1 * num2;
                    break;

                case "divisão":
                    resultado = num1 / num2;
                    break;


                default:
                    Console.WriteLine("Operação inválida! ");
                    break;
            }

            Console.WriteLine($"Calculo : {num1} com {num2} = {resultado} ");


        }
    }
}

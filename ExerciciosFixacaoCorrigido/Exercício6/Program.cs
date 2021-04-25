using System;

namespace Exercício6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            string resposta = "";

            for (var i = 0; i < nomes.Length; i++)
            {       
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Digite o nome de uma pessoa: "); 

                Console.ResetColor();
                nomes[i] = Console.ReadLine();
            }
                    

            Console.WriteLine("Digite o nome da pessoa que você quer encontrar: ");
            resposta = Console.ReadLine();


            foreach (var item in nomes)
            {
                if(item == resposta){
                    Console.WriteLine($"ACHEI! O nome {resposta} está cadastrado! ");
                }

            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Fim do programa. Caso não tenha achado o nome, tente digitar um nome válido! ");


        }
    }
}

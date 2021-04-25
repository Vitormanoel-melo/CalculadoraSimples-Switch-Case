using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
                string nome = "";

                string senha = "";

            do{
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Digite seu nome: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                nome = Console.ReadLine();

                Console.WriteLine("----------------");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Digite sua senha: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                senha = Console.ReadLine();

                if(senha == nome){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha não aceita! Sua senha não deve ser igual ao seu nome!");
                }
            }while(senha == nome);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Cadastro realizado com secesso!" );

        }
    }
}

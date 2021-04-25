using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bem vindo a seletiva para o time de Counter Strike");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Você gostaria de participar? Sim ou não");
            string resposta = Console.ReadLine();
            if(resposta == "Sim"){
                Console.WriteLine("Que legal! Vamos analisar seu currículo");
                Console.WriteLine("Agora insira sua média escolar");
                int media = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a sua quantidade de faltas");
                int faltas = int.Parse(Console.ReadLine());
                
                if(media >= 50 && faltas <= 10){
                Console.WriteLine("Parabéns! Seja bem vindo!");
                }
                else{
                    Console.WriteLine("Que pena, você precisa melhorar suas notas e faltas!");
                }

            }
            else{
                Console.WriteLine("Blz, passar bem!");
            }
            
            
        
            
            


            
        }
    }
}
 
using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo\nAqui você fica sabendo se você poderá votar este ano ou não!");
            Console.WriteLine("-------------------------------------------------------------------------");

            
            Console.Write("Digite seu ano de nascimento (apenas números): ");
            int nasc = int.Parse(Console.ReadLine());

            Console.Write("Agora digite o ano atual (apenas números): ");
            int atual = int.Parse(Console.ReadLine());


            int resultado = atual - nasc;


            if(resultado < 16){
                Console.WriteLine("Você não poderá votar este ano!");
            }

            else if(resultado >= 16 && resultado == 17 ){
                Console.WriteLine("Você pode votar este ano, mas você não é obrigado a votar!");
            }

            else if(resultado >=18 && resultado < 70){
                Console.WriteLine("Você pode votar este ano, para pessoas acima dos 18 anos o voto é obrigatório");
            }
            
            else if(resultado >= 70){
                Console.WriteLine("Você pode votar, mas seu voto não é obrigatório!\nPessoas com 70 anos ou mais não são obrigadas a votar e nem justificar!");
            }
            
            
        }
    }
}

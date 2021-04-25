using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {   
   
            Console.WriteLine("Bem vindo! Aqui você consegue saber se você pode ou não votar esse ano.");
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Digite seu ano de nascimento (apenas números)");
            int nasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual (apenas números)");
            int atual = int.Parse(Console.ReadLine());

            int idade = 0;

            idade = atual - nasc;

            if(idade >0 && idade < 16){
                Console.WriteLine("Você não pode votar esse ano!");
            }
            else if(idade >= 16 && idade <=17){
                Console.WriteLine("Você pode votar este ano, mas seu voto não é obrigatório!");
            }
            else if(idade >17 && idade <70){
                Console.WriteLine("Seu voto esse ano é obrigatório!");
            }
            else if(idade >70){
                Console.WriteLine("Seu voto não é obrigatório! \nPessoas com 70 anos ou mais não precisam votar e nem justificar!");
            }

           

                



        }
    }
}

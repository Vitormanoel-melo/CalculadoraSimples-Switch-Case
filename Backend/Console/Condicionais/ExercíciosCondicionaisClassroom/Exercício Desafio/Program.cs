using System;

namespace Exercício_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para saber sua categoria digite sua idade (Apenas números): ");
            int idade = int.Parse(Console.ReadLine());
            
            if(idade >= 5 && idade <= 7){
                Console.WriteLine("Sua categoria é: Infantil A");
            }
            if(idade >=8 && idade <=10){
                Console.WriteLine("Sua categoria é: infantil B");
            }
            if(idade >= 11 && idade<=13){
                Console.WriteLine("Sua categoria é: Juvenil A");
            }
            if(idade >=14 && idade <=17){
                Console.WriteLine("Sua categoria é: Juvenil B");
            }
            if(idade >= 18){
                Console.WriteLine("Sua categoria é: Sênior");
            }

        }
    }
}

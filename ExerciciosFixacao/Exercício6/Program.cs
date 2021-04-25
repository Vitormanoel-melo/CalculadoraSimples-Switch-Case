using System;

namespace Exercício6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3];

            for (var i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Digite o nome da {i}° pessoa ");
                nomes[i] = Console.ReadLine();
            }

                 Console.WriteLine("Digite o nome da pessoa que você deseja encontrar");
                string nomeproc = Console.ReadLine();

                foreach (var nome in nomes){
                    if(nome == nomeproc){
                        Console.WriteLine("ACHEI");
                    }else{
                        Console.WriteLine("NÃO ACHEI");
                    }
                    
                }





        }
    }
}

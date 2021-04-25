using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());


            double media = (nota1 + nota2) / 2;

            Console.WriteLine("Média: " + media);

            string situacao = "";

            if(media > 7){
                situacao = "Aprovado";
            } 
            else{
                situacao = "Reprovado";
            }

            Console.WriteLine(situacao);

        }
    }
}

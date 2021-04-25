using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] produtos = {"maça", "batata", "cenoura", "laranja", "tomate"};
            double [] precos = {2, 5, 6};
            int[] idade = {16, 17, 17 };
            string [] professores = {"Thiago", "Tsukamoto", "Paulo"};

            string [] nomesAlunos = new string [5];

            string resposta;
            do{
            
            Console.Write("Você deseja ver a lista de (a)produtos, (b)preços, (c)idade ou (d)professores ");
            resposta = Console.ReadLine();

            if(resposta == "a"){

                for (int contador = 0; contador < produtos.Length; contador++)
                {
                    // Console.Write(contador + ": ");
                    Console.WriteLine(produtos[contador]);
                }
            }
            else if(resposta == "b"){
                for (int contador = 0; contador < precos.Length; contador++)
                {
                    // Console.Write(contador + ": ");
                    Console.WriteLine(precos[contador]);
                }
            }
            else if(resposta == "c"){
                for (int contador = 0; contador < idade.Length; contador++)
                {
                    // Console.Write(contador + ": ");
                    Console.WriteLine(idade[contador]);
                }
            }
            else if(resposta == "d"){
                for (int contador = 0; contador < professores.Length; contador++)
                {
                    // Console.Write(contador + ": ");
                    Console.WriteLine(professores[contador]);
                }
            }



            }while(resposta != "a" && resposta != "b" && resposta != "c" && resposta != "d");


        }
    }
}

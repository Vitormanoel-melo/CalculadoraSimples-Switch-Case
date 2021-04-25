using System;

namespace Exercício_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {


            int atual = 1, anterior = 0, soma;



            for (int i = 0; atual < 700; i++)
            {


                soma = anterior + atual;

                Console.WriteLine(atual);
                
                anterior = atual;
                atual = soma;

            }

        }
    }
}

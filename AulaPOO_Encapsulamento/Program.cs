using System;
using AulaPOO_Encapsulamento.Classes;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.NomeTitular = "Vitor";

            m.Numero = "12345678";

            m.Bandeira = "MasterCard";



            Console.WriteLine($"O Títular {m.NomeTitular} - Token {m.Token} - CVV - {m.Cvv} ");



        }
    }
}

using System;
using AulaPOO_PolimosrfismoSobreposicao.Classes;

namespace AulaPOO_PolimosrfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman mega = new Megaman();

            Console.WriteLine("MegaMan");
            mega.Correr();
            mega.Pular();


            Zero zero = new Zero();

            Console.WriteLine("Zero");
            zero.Correr();
            zero.Pular();


        }
    }
}

using System;
using AulaPOO_PolimosrfismoSobrecarga.Classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            fun.Mostrar();
            fun.Mostrar(0);
            fun.Mostrar("Paulo");

            Console.Beep(1000, 2000);

        }
    }
}

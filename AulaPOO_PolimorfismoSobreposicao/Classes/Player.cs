using System;

namespace AulaPOO_PolimosrfismoSobreposicao.Classes
{
    public abstract class Player
    {

        public float velocidade;
        public float forcaPulo;

        public virtual void Correr(){
            Console.WriteLine("Correndo na velocidade 10");
        }

        public virtual void Pular(){
            Console.WriteLine("Pulando com força 5");
        }

    }
}
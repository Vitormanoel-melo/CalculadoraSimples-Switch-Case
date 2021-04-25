
using System;

namespace Poo_aula2
{
    public class Personagem
    {
        
        public string nome;
        public int idade;
        public string armadura;
        public string IA = "Jarvis";
        public int vida = 100;



        public int Atacar1(){

            return 10;
        }

        public int Atacar2(){

            return 20;
        }

        public int Defender(int ataque){
            
            return this.vida = vida - ataque;;
        }




    }
}
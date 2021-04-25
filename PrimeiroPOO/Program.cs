using System;

namespace Poo_aula2
{
    class Program
    {
        static void Main(string[] args)
        {

            int vidaDoJogador2;
            
            Personagem jogador1 = new Personagem();

            jogador1.nome = "Vitor";
            jogador1.idade = 17;
            jogador1.armadura = "Face-Shield";
            jogador1.IA = "Pura Skill";


            Personagem jogador2 = new Personagem();
            
            jogador2.nome = "Tony Stark";
            jogador2.idade = 35;
            jogador2.armadura = "MK3";


            Console.WriteLine($"Partida {jogador1.nome} VS {jogador2.nome} ");
            Console.WriteLine($"Jogador 1 armadura: {jogador1.armadura} || Jogador 2 armadura: {jogador2.armadura} ");
            Console.WriteLine($"Jogador 1 IA: {jogador1.IA} || Jogador 2 IA: {jogador2.IA} ");


            vidaDoJogador2 = jogador2.Defender(jogador2.Atacar1());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine("O jogador morreu!");
            }else{
            Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida}  ");
            
            }
                



            



        }
    }
}

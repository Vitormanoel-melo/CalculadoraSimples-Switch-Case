using System;
using Desafio2.Classes;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();

            int escolha;
            int idade = 0;
            
            
            Console.WriteLine("Digite o nome do jogador");
            jogador.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a posição do jogador");
            Console.WriteLine("(a) Ataque ");
            Console.WriteLine("(b) Meio-campo ");
            Console.WriteLine("(c) Defesa ");
            jogador.Posicao = Console.ReadLine();
            
            Console.WriteLine("Digite a data de nascimento do jogador (data, mês, ano) - 00/00/0000 ");
            jogador.Nascimento = Console.ReadLine();
            
            Console.WriteLine("Digite a nacionalidade do jogador");
            jogador.Nacionalidade = Console.ReadLine();
            
            Console.WriteLine("Digite a altura do jogador (cm) ");
            jogador.Altura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o peso do jogador (kg) ");
            jogador.Peso = float.Parse(Console.ReadLine());
            
            do{
            Console.WriteLine("Escolha uma opção"); 
            Console.WriteLine("[1] - Consultar dados do jogador ");
            Console.WriteLine("[2] - Consultar aposentadoria do jogador ");
            Console.WriteLine("[0] - Sair ");
            escolha = int.Parse(Console.ReadLine());

            idade = jogador.CalcularIdade();

            if(escolha == 1 ){
                
                Console.WriteLine(EscreverDados(idade));
            }
            else if(escolha == 2){
                Console.WriteLine(jogador.Aposentar(idade));
            }

            }while(escolha != 0);
           


            string EscreverDados(int idade){
                Console.WriteLine($"Nome do jogador: {jogador.Nome} ");
                Console.WriteLine($"Posição do jogador: {jogador.Posicao} ");
                Console.WriteLine($"Idade do jogador: {idade} anos ");
                Console.WriteLine($"Nacionalidade do jogador: {jogador.Nacionalidade} ");
                Console.WriteLine($"Altura do jogador (CM): {jogador.Altura} cm ");
                Console.WriteLine($"Peso do jogador (KG): {jogador.Peso} kg ");

                return "";
            }



        }
    }
}

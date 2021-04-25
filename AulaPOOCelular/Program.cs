using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao;

            Celular celular1 = new Celular();

            Console.Write("Insira a cor do celular: ");
            celular1.cor = Console.ReadLine();

            Console.Write("Insira o modelo do celular: ");
            celular1.modelo = Console.ReadLine();

            Console.Write("Insira o tamanho do celular (em polegadas, e apenas números): ");
            celular1.tamanho = float.Parse(Console.ReadLine());


            Console.WriteLine("O celular está ligado? (S/N) ");
            string resposta = Console.ReadLine().ToLower();

            do{
            if(resposta == "s"){
                celular1.ligado = true;
            }
            else if(resposta == "n"){
                celular1.ligado = false;
            }


            
            Console.WriteLine("------- MENU -------");

            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("[1] - Ligar ou desligar o celular ");
            Console.WriteLine("[2] - Fazer ligação");
            Console.WriteLine("[3] - Enviar mensagem ");
            Console.WriteLine("[4] - Mostrar ficha técnica do celular  ");
            Console.WriteLine("[0] - Sair ");
            opcao = Console.ReadLine().ToLower();


            switch(opcao){

                case "1":
                    resposta = celular1.LigarDesligar(resposta);
                    break;

                case "2":

                    if(celular1.ligado == false){
                        resposta = celular1.ValidarLigacao(resposta);

                    }

                    if(celular1.ligado == true){
                        celular1.FazerLigacao(resposta);

                    }

                    break;


                case "3":   
                    if(celular1.ligado == false){
                        resposta = celular1.ValidarLigacao(resposta);
                    }

                    if(celular1.ligado == true){
                        celular1.EnviarMensagem(resposta);
                    }

                    break;


                case "4":
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine($"Cor do celular: {celular1.cor}");
                    Console.WriteLine($"Modelo do celular: {celular1.modelo}");
                    Console.WriteLine($"Tamanho do celular {celular1.tamanho}");
                    Console.ResetColor();
                    break;


                case "0":
                    Console.WriteLine("Até Breve!");
                    break;


                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }

            }while(opcao != "0");





        } 
    }
}

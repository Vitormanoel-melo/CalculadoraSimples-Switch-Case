using System;

namespace AulaPOOCelular.classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;


        public string LigarDesligar(string resposta){

            Console.WriteLine("Deseja Ligar ou Desligar? [s] - Ligar [n] - Desligar");
            resposta = Console.ReadLine();

            if(resposta == "s"){
                Console.WriteLine("Aguarde... ");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Ligando o celular... ");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("O celular foi ligado ");
            }
            else if(resposta == "n"){
                Console.WriteLine("Aguarde... ");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Desligando o celular... ");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("O celular foi desligado ");
            }


            return resposta;
        }


        // Fazer ligação




        public void FazerLigacao(string resposta){

            Console.WriteLine("Insira o número que você quer fazer ligação (apenas números): ");
            float numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Aguarde...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Chamando...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Chamando...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Chamada conectada");

            Console.WriteLine("Para encerrar a ligação digite E");
            string ligacao = Console.ReadLine().ToLower();
            if(ligacao == "e"){
                Console.WriteLine("Chamada encerrada");
            }

        }



        public string ValidarLigacao(string resposta){
            Console.WriteLine("Para fazer ligação você deve ligar o celular, para ligar digite S");
            resposta = Console.ReadLine().ToLower();
            Console.WriteLine("Aguarde... ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Ligando o celular... ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("O celular foi ligado ");

            return resposta;
        }



        // Enviar mensagem




        public void EnviarMensagem(string resposta){
            

            Console.WriteLine("Que tipo de mensagem você deseja enviar [a] - E-mail [b] - SMS ");
            string tipo = Console.ReadLine();

            if(tipo == "a"){
                Console.WriteLine("Digite o endereco de email");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o conteúdo da mensagem");
                string text = Console.ReadLine();
                
                Console.WriteLine("Enviando mensagem...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Mensagem enviada com sucesso");

                Console.WriteLine("Detalhes da mensagem");
                Console.WriteLine($"Destinatário: {email} ");
                Console.WriteLine($"Conteúdo da mensagem: {text} ");
            }

            if(tipo == "b"){
                Console.WriteLine("Digite o número de quem você quer mandar o SMS");
                string sms = Console.ReadLine();

                Console.WriteLine("Digite o conteúdo da mensagem");
                string smsText = Console.ReadLine();
                
                Console.WriteLine("Enviando mensagem...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Mensagem enviada com sucesso");

                Console.WriteLine("Detalhes da mensagem");
                Console.WriteLine($"Destinatário: {sms} ");
                Console.WriteLine($"Conteúdo da mensagem: {smsText} ");

            }   
        

        }
       

        public string ValidarMensagem(string resposta){
            Console.WriteLine("Para enviar mensagens você deve ligar o celular, para ligar digite S");
            resposta = Console.ReadLine().ToLower();
            Console.WriteLine("Aguarde... ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Ligando o celular... ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("O celular foi ligado ");

            return resposta;
        }





       


    }
}
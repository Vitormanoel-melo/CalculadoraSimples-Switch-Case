using System;
using DesafioPolimorfismo.Classes;

namespace DesafioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe maquina = new MaquinaCafe(); 

            string resposta;
            double acucar;
            char escolha;
            string preparar = "";

            Console.WriteLine("Digite a quantidade de açúcar que deseja colocar na máquina");
            maquina.acucarDisponivel = double.Parse(Console.ReadLine());


            Console.WriteLine("Deseja preparar um café? s/n");
            escolha = char.Parse(Console.ReadLine());

            do{

            if(escolha == 's'){

            Console.WriteLine($"Quantidade de açúcar disponivel: {maquina.acucarDisponivel} gramas ");
            Console.WriteLine("Digite a quantidade de açúcar que deseja em seu café (apenas numeros e em gramas)");
            resposta = Console.ReadLine();
            
            if(resposta != ""){
                acucar = Convert.ToDouble(resposta);
                if(maquina.acucarDisponivel >= acucar){
                    Console.WriteLine(maquina.FazerCafe(acucar));
                    Console.WriteLine("Aguarde...");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Retire o café da máquina, cuidado pois está quente");
                    Console.WriteLine($"Açúcar disponível: {maquina.acucarDisponivel} gramas ");
                }
                else if(maquina.acucarDisponivel < acucar){
                    Console.WriteLine("Não há açucar suficiente para o preparo");
                }


            }
            else if(resposta == ""){
                Console.WriteLine(maquina.FazerCafe());
                Console.WriteLine("Aguarde...");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Retire o café da máquina, cuidado pois está quente");
                Console.WriteLine($"Açúcar disponível: {maquina.acucarDisponivel} gramas");

            }


            }


            if(escolha == 's'){
                Console.WriteLine("Deseja preparar outro café? s/n ");
                preparar = Console.ReadLine();
            }
            



            if(escolha == 'n'){

            }


            }while(preparar == "s");








        }
    }
}

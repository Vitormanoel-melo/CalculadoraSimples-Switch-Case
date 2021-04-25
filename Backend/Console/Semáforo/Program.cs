using System;

namespace Semáforo
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("O sinal está vermelho? ");
            string sinal1 = Console.ReadLine();

            string resultado1 = sinal1;

            string situacao = "";

            if(resultado1 == "Sim" ){
                situacao = "Pare o veículo";
            } else{
                
                Console.WriteLine("O sinal está amarelo?");
                string sinal2 = Console.ReadLine();
                string resultado2 = sinal2;

                if(resultado2 == "Sim"){
                situacao = "Reduza a velocidade e pare o veículo";
            } 
                else{
                    Console.WriteLine("Tem obras na pista");
                    string sinal3 = Console.ReadLine();

                    string resultado3 = sinal3;
                    if(sinal3 == "Não"){
                        situacao = "Continue acelerando";
                    }
                    if(sinal3 == "Sim"){
                        Console.WriteLine("Tem como desviar?");
                        string sinal4 = Console.ReadLine();

                        string resultado4 = sinal4;
                        if(sinal4 == "Sim"){
                            situacao = "Desvie e continue acelerando";
                        } else{
                            situacao = "Pare o veículo";
                        }
                    }
            }
            }

            Console.WriteLine(situacao);
            
        }
    }
}

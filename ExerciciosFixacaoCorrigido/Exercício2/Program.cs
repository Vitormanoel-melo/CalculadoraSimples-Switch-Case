using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo = "" ;
            float litros = 0;
            
            Console.WriteLine("Escolha o tipo de combustível: \n(G) Gasolina - R$5,30 por litro \n(A) Álcool - R4,90 por litro");
            tipo = Console.ReadLine().ToLower();
            
            Console.WriteLine("Digite a quantidade de litros");
            litros = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch(tipo){

                case "g":
                    ValorPagar( tipo , litros , resultado);
                    break;


                case "a":
                    ValorPagar2(tipo, litros, resultado);
                    break;
            }

            Console.WriteLine($"Quantidade de litros {litros} Litros. \nO valor a ser pago é: {resultado} reais ");

            float ValorPagar(string t, float l, float r){

                if(litros <=20){
                        resultado = (5.30f - (5.30f * 0.04f)) * litros;                     
                    }
                    
                else if(litros >20){
                        resultado = (5.30f - (5.30f * 0.06f)) * litros;
                    }
                
                return resultado;
            }

            float ValorPagar2(string t, float l, float r){
                if(litros <=20){
                        resultado = (4.90f - (4.90f * 0.03f)) * litros;                     
                }
                
                else if(litros >20){
                        resultado = (4.90f - (4.90f * 0.05f)) * litros;
                }
                
                return resultado;
                    
            }
            
        }
    }
}

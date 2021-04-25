using System;

namespace AulaPOO_Abstracao.Classes
{
    public class Debito : Cartao
    {   

        private float saldo = 600;


        public void Pagar(float valor){
            
            if(saldo >= valor){
                Valor = valor;
                saldo = saldo - valor;

                Console.WriteLine($"Data da compra {Data}");
                Console.WriteLine($"Valor a pagar: R${Valor} ");
                Console.WriteLine($"Saldo atual do cartão: R${saldo}");
                

            }

            
            else if(saldo < valor){
                Console.WriteLine("Saldo insuficiente");

            }
            


            
        }


        public override string Cancelar()
        {
            if(saldo >= 0){
            Console.WriteLine("Se desejar cancelar seu pedido digite 1, se não digite 0");
            string cancelar = Console.ReadLine();
            
            if(cancelar == "1"){
                Console.WriteLine("Pedido Cancelado");
                
            }
            else{
                Console.WriteLine("Compra realizada com sucesso ");
            }
            }

            return "";
        }

        public override string SalvarCartao()
        {
            Console.WriteLine("Insira a Bandeira");
            bandeira = Console.ReadLine();

            Console.WriteLine("Insira o Número");
            numero = Console.ReadLine();
            
            Console.WriteLine("Insira o Títular");
            titular = Console.ReadLine();
            
            Console.WriteLine("Insira o CVV");
            cvv = Console.ReadLine();

            return "";
        }
    }
}
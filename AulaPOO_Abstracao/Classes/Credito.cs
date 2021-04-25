using System;

namespace AulaPOO_Abstracao.Classes
{
   public class Credito : Cartao
    {
        private float limite = 3000;
        
        public void Pagar(float valor){
            Console.WriteLine("Dados do cartão");
                       
            Console.WriteLine($"Bandeira: {bandeira}");
                       
            Console.WriteLine($"Numero: {numero}");       

            Console.WriteLine($"Titular: {titular}");

            Console.WriteLine($"CVV: {cvv}");
            
            Console.WriteLine("Digite a quantidade de parcelas:");
            int parcela = int.Parse(Console.ReadLine());

            if(parcela >= 2 && parcela <= 6 && limite >= valor){
                limite = limite - valor;
                valor = (valor / parcela);
                valor = valor + (valor * 0.05f);
                Valor = valor;

                Console.WriteLine($"Data da compra {Data}");
                Console.WriteLine($"Quantidade de parcelas {parcela} ");
                Console.WriteLine($"Valor a pagar de cada parcela: R${Valor} ");
                Console.WriteLine($"Limite atual do cartão: R${limite}");

            }   

            else if(parcela >= 2 && parcela <= 6 && limite < valor){
                Console.WriteLine("Limite Excedido");
            }

            else if(parcela >= 7 && parcela <= 12 && limite >= valor){
                limite = limite - valor;
                valor = (valor / parcela);
                valor = valor + (valor * 0.08f);
                Valor = valor;

                Console.WriteLine($"Data da compra {Data}");
                Console.WriteLine($"Quantidade de parcelas: {parcela} ");
                Console.WriteLine($"Valor a pagar de cada parcela: R${Valor} ");
                Console.WriteLine($"Limite atual do cartão: R${limite}");

            }
            else if(parcela >= 7 && parcela <= 12 && limite < valor){
                Console.WriteLine("Limite Excedido");
            }

            
        }

        public override string Cancelar()
        {
            Console.WriteLine("Se desejar cancelar seu pedido digite 1, se não digite 0");
            string cancelar = Console.ReadLine();
            
            if(cancelar == "1"){
                Console.WriteLine("Pedido Cancelado");
                
            }
            else{
                Console.WriteLine("Compra realizada com sucesso ");
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
            
            
            return"";
        }
        
    }
}
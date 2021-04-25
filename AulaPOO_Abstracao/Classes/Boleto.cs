using System;

namespace AulaPOO_Abstracao.Classes
{
     public class Boleto : Pagamento
    {
        private float codigoDeBarras;

        public float CodigoDeBarras{
            get{return codigoDeBarras;}
        }


        public void Registrar(){    
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();
        }

        public void GerarBoleto(){
            
            Console.WriteLine($"O valor do boleto é R${this.Valor * 0.88f} ");
            Console.WriteLine($"Data: {this.Data} ");
            Console.WriteLine($"Data de vencimento : {this.Data.AddDays(10)} ");
            Console.WriteLine($"Código de barras {this.CodigoDeBarras} ");

        }

        public override string Cancelar()
        {
            Console.WriteLine("Se desejar cancelar seu pedido digite 1, se não digite 0");
            string cancelar = Console.ReadLine();
            
            if(cancelar == "1"){
                Console.WriteLine("Pedido Cancelado");
                
            }
            else{
                Console.WriteLine("Pedido realizado com sucesso, estamos aguardando o pagamento");
            }

            return "";
        }


    }
}
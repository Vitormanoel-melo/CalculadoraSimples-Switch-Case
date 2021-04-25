using System;

namespace AulaPOO_Encapsulamento.Classes
{
    public class Cartão
    {
        private string numero;

        public string Numero{
            get{return numero;}
            set{numero = value;}
        }

        private string nomeTitular;

        public string NomeTitular{
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }

        public string bandeira;

        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }

        protected string token = "qwertyui";
        
        public string Token{
            get{return token;}
        }

        private string cvv;

        public string Cvv{get;set;}

        protected float limite = 5000;

        public float Limite{get; set;}
        
        public string RegistarCompra(bool validado){

            return "";
        }



    }
}
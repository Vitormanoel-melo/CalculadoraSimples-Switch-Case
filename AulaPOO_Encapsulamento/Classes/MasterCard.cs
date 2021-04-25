using System;

namespace AulaPOO_Encapsulamento.Classes
{
    public class MasterCard : Cartão

    {
        private int parcelas;

        public void ExibirLimite(){

            Console.WriteLine(this.limite);
        }
    }
}
using System;

namespace AulaPOO_Abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        public DateTime Data{
            get;
            set;
        }
        protected float valor;

        public float Valor{
            get; set;
        }

        public abstract string Cancelar();

    }
}
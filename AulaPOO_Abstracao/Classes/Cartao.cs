namespace AulaPOO_Abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;

        public string Bandeira{
            get;
            set;
        }

        public string numero;
        public string titular;
        public string cvv;

        public abstract string SalvarCartao();



    }
}
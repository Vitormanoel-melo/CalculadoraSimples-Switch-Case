namespace AulaPOO_PolimosrfismoSobreposicao.Classes
{
    public class Zero : Player
    {

        public override void Correr()
        {
            base.Correr();
        }

        public override void Pular()
        {
            System.Console.WriteLine("Pulando com força 5 e dando um dash para frente");
        }

    }
}
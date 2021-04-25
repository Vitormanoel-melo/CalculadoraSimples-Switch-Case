namespace AulaPOO_PolimosrfismoSobreposicao.Classes
{
    public class Megaman : Player
    {


        public override void Correr()
        {
            System.Console.WriteLine("Correndo em velocidade 100x");
        }

        public override void Pular()
        {
            base.Pular();
        }

    }
}
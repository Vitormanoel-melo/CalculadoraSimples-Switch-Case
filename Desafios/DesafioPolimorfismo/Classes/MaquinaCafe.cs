namespace DesafioPolimorfismo.Classes
{
    public class MaquinaCafe
    {
        public double acucarDisponivel = 50;

        public string FazerCafe(double acucar){
            if(acucarDisponivel >= acucar){
                acucarDisponivel = acucarDisponivel - acucar;
            }

            return $"O café será feito com {acucar} gramas de açúcar";

        }
        
        public string FazerCafe(){
            if(acucarDisponivel >= 10){
            acucarDisponivel = acucarDisponivel - 10;
            }
            else {
                return "Não há açúcar disponivel na máquina, o café será feito sem açucar";
            }

            return "O café será feito com 10 gramas de açúcar";


        }
        



    }
}
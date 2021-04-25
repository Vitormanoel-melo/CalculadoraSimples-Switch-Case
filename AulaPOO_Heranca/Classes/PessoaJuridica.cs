namespace AulaPOO_Heranca.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCnpj(string documento){
            if(documento == ""){
                return false;
            }else{
                return true;
            }

        }

        public bool ValidarInscricao(string documento){
            if(documento == ""){
                return false;
            }else{
                return true;
            }

        }


    }
}
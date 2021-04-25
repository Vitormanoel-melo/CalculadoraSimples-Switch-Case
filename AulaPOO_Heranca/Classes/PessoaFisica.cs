namespace AulaPOO_Heranca.Classes
{
    public class PessoaFisica : Pessoa
    {
        
        public string cpf;
        public string rg;

        public bool ValidarCpf(string documento){

            if(documento != ""){
                return true;
            }
            return false;
            
        }

        public bool ValidarRg(string documento){

            if(documento != ""){
                return true;
            }
            return false;
            
        }

    }
}
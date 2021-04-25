namespace Desafio1.Classes
{
    public class Elevador
    {
        protected int andarAtual = 0;
        public int AndarAtual{
            get{return andarAtual;}
            set{andarAtual = value;}
        }

        protected int totalDeAndares;
        public int TotalDeAndares{
            get{return totalDeAndares;}
            set{totalDeAndares = value;}
        }


        protected int capacidade = 10;
        public int Capacidade{
            get{return capacidade;}
            set{capacidade = value;}
        }


        protected int pessoasNoElevador;

        public int PessoasNoElevador{
            get{return pessoasNoElevador;}
            set{pessoasNoElevador = value;}
        }


        public void Inicializar(int capacidade, int andares){
            Capacidade = capacidade;
            TotalDeAndares = andares;
        }

        public void Entrar(int pessoas){
            capacidade = capacidade - pessoas;
            pessoasNoElevador = pessoas + pessoasNoElevador;
        }

        public void Sair(int remove){
            pessoasNoElevador = pessoasNoElevador - remove;
            capacidade = capacidade + remove;
        }

        public void Subir(int subir){
            totalDeAndares = totalDeAndares - subir;
            andarAtual = andarAtual + subir;


        }

        public void Descer(int descer){
            totalDeAndares = totalDeAndares + descer;
            andarAtual = andarAtual - descer;

        }




    }
}
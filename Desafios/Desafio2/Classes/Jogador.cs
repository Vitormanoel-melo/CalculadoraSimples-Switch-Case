using System;

namespace Desafio2.Classes
{
    public class Jogador
    {
        protected string nome;
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }


        protected string posicao;
        public string Posicao{
            get{return posicao;}
            set{posicao = value;}
        }

        protected string nascimento;
        public string Nascimento{
            get{return nascimento;}
            set{nascimento = value;}
        }


        protected string nacionalidade;
        public string Nacionalidade{
            get{return nacionalidade;}
            set{nacionalidade = value;}
        }


        protected float altura;
        public float Altura{
            get{return altura;}
            set{altura = value;}
        }


        protected float peso;
        public float Peso{
            get{return peso;}
            set{peso = value;}
        }
        
        public int CalcularIdade(){
            DateTime data = Convert.ToDateTime(nascimento);
            TimeSpan ts = DateTime.Today - data;

            DateTime idade = (new DateTime() + ts).AddYears(-1).AddDays(-1);

            return idade.Year;
        }

        public string Aposentar(int idade){
            if(posicao == "a" && CalcularIdade() >= 35){
                return $"O jogador tem {CalcularIdade()} anos, e joga na posição de Ataque! então ele já pode se aposentar";
            }
            else if(posicao == "a" && CalcularIdade() <  35 ){
                idade = 35 - idade;
                return $"Faltam {idade} anos para o jogador se aposentar";
            }
            else if(posicao == "b" && CalcularIdade() >=  38 ){
                return$"O jogador tem {CalcularIdade()} anos, e joga na posição de Meio-Campo! então ele já pode se aposentar";
            }
            else if(posicao == "b" && CalcularIdade() < 38){
                idade = 38 - idade;
                return $"Faltam {idade} anos para o jogador se aposentar";
            }
            else if(posicao == "c" && CalcularIdade() >= 40){
                return$"O jogador tem {CalcularIdade()} anos, e joga na posição de Defesa! então ele já pode se aposentar";
            }
            else if(posicao == "c" && CalcularIdade() < 40){
                idade = 40 - idade;
                return $"Faltam {idade} anos para o jogador se aposentar";
            }
        
        
        return "";

        }




    }
}
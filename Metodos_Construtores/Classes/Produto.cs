using System;

namespace MetodosConstrutores.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        
        public int Estoque { get; set; }
        

        public Produto(){

        }
        
        public Produto(int codigo, string nome, string desc, int estoque ){
            if(codigo < 0){
                Console.WriteLine("Valor Inválido");
            }
            
            else{
            Codigo = codigo;
            Nome = nome;
            Descricao = desc;
            Estoque = estoque;

            // Console.WriteLine($"Produto casastrado Código - {Codigo} - Nome {Nome} ");
            }
        }

        public Produto(int codigo){
            if(codigo >= 0){
                Codigo = codigo;
                Nome = "Pepsi";
                // Console.WriteLine($"Produto casastrado Código - {Codigo} - Nome {Nome ?? "Sem nome"} ");

            }
            else{
                Console.WriteLine("Código Inválido");
            }


        }
        


    }
}
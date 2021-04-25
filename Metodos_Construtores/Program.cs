using System;
using MetodosConstrutores.Classes;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine("Digite o código do produto");
            produto1.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto");
            produto1.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a descrição do produto");
            produto1.Descricao = Console.ReadLine();
            
            Console.WriteLine("Insira o estoque do produto");
            produto1.Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine($"Codigo = {produto1.Codigo} Nome = {produto1.Nome ?? "Null"} Descrição = {produto1.Descricao ?? "null "} Estoque = {produto1.Estoque}");
            

            Produto produto2 = new Produto(1);
            
            produto2.Nome = "Coca-Cola";
            produto2.Descricao = "Refrigerante de cola";


            Console.WriteLine($"Codigo = {produto2.Codigo} Nome = {produto2.Nome ?? "Null"} Descrição = {produto2.Descricao ?? "null "} Estoque = {produto2.Estoque}");


            Produto produto3 = new Produto(1, "Produto 3", "Este é o produto 3", 20 );                

            Console.WriteLine($"Codigo = {produto3.Codigo} Nome = {produto3.Nome ?? "Null"} Descrição = {produto3.Descricao ?? "null "} Estoque = {produto3.Estoque}");


           


        }
    }
}

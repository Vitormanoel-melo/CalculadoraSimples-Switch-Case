using System;
using POO_Interfaces.CLasses;

namespace POO_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto(1, "PlayStation 5", 10000f);
            Produto p2 = new Produto(2, "XBOX Series X", 5000f);
            Produto p3 = new Produto(3, "Nintendo Switch", 3000f);

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);

            Console.ForegroundColor = ConsoleColor.Green;
            carrinho.Listar();

            carrinho.Alterar(1, p3);

            Console.ResetColor();

            Console.WriteLine("Após alteração\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            carrinho.Listar();
            
            Console.ResetColor();

            carrinho.Deletar(p2);

            Console.WriteLine("Após remoção\n");

            Console.ForegroundColor = ConsoleColor.Red;
            carrinho.Listar();

            Console.ResetColor();

        }
    }
}

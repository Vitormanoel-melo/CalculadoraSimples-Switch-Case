using System;
using System.Collections.Generic;
using ListasDeObjetos.classes;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>(); 

            produtos.Add(new Produto (5, "Apple Watch", 3522.56f ) );
            produtos.Add(new Produto (8, "Xiaomi Watch", 1522.45f ) );
            produtos.Add(new Produto (78, "Zenfone Asus", 2522.87f ) );
            produtos.Add(new Produto (2, "Samsung", 2522.87f ) );
            produtos.Add(new Produto (22, "Motorola G8", 2522.87f ) );

            Produto p1 = new Produto();
            p1.Codigo = 67;
            p1.Nome = "Iphone 12";
            p1.Preco = 11999.56f;

            produtos.Add(p1);

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Nome: {item.Nome} - Código: {item.Codigo} - Preço: {item.Preco}  ");
            }

            produtos.RemoveAt(3);

            Console.WriteLine("\nRemoção feita:\n");

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Nome: {item.Nome} - Código: {item.Codigo} - Preço: {item.Preco}  ");
            }

            produtos.RemoveAll(x => x.Codigo == 78 );

            Console.WriteLine("\nRemoção do Zenfone ASUS Feita: \n");

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Nome: {item.Nome} - Código: {item.Codigo} - Preço: {item.Preco}  ");
            }


        }
    }
}

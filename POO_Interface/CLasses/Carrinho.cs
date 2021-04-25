using System;
using System.Collections.Generic;

namespace POO_Interfaces.CLasses
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        public void Listar()
        {
            foreach (var item in carrinho)
            {
                Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: R${item.Preco}  ");
            }

        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Alterar(int codigo, Produto novoProduto)
        {
            // carrinho.Find(x => x.Codigo == codigo).Codigo = novoProduto.Codigo;
            carrinho.Find(x => x.Codigo == codigo).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = novoProduto.Preco;
            carrinho.Find(x => x.Codigo == codigo).Codigo = novoProduto.Codigo;
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }



    }
}
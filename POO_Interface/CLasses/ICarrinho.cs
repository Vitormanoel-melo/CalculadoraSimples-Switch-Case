namespace POO_Interfaces.CLasses
{
    public interface ICarrinho
    {
        void Listar();

        void Cadastrar(Produto produto);

        void Alterar(int codigo, Produto novoProduto);

        void Deletar(Produto produto);
        

    }
}
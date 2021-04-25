using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string senha ="";
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta = "";

            string[] nomes = new string[10];
            float[] preco = new float[10];
            string[] desconto = new string[10];
            float[] valorDesconto = new float[10];

            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("---- Cadastro de Produtos ----");
            Console.WriteLine("------------------------------");

            do{
                Console.Write("Digite a senha para acessar o sistema: ");
                senha = Console.ReadLine();
                senhaValida = Login(senha);
            }while(senhaValida);

            
            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma das opções abaixo");
                Console.WriteLine("[1] - Cadastrar Produtos ");
                Console.WriteLine("[2] - Listar Produtos ");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    do{
                        if(contador < 10){

                        Console.Write($"Digite o nome do {contador + 1}º produto: ");
                        nomes[contador] = Console.ReadLine();

                        Console.Write("Digite o preço do produto: ");
                        preco[contador] = float.Parse(Console.ReadLine());

                        Console.WriteLine("O produto tem desconto? Sim/Não");
                        desconto[contador] = Console.ReadLine().ToLower();

                        bool funcaoDescontar = Descontar(desconto[contador]);

                        if(funcaoDescontar){
                            Console.Write("Digite o valor do desconto (apenas números, exemplo: 0,75): ");
                            valorDesconto[contador] = float.Parse(Console.ReadLine());
                        }
                        preco[contador] = preco[contador] - valorDesconto[contador];


                        contador++;
                        }else{
                            Console.WriteLine("Limite excedido!");
                            break;
                        }

                        Console.WriteLine("Deseja cadastrar outro produto? [s] - Sim [n] - Não ");
                        resposta = Console.ReadLine();


                    }while(resposta == "s");

                        break;

                    case 2:
                        for (var a = 0; a < contador; a++)
                        {   
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Produto: {nomes[a]}.   O produto teve desconto: {desconto[a]}    Valor do desconto: R${valorDesconto[a]}    Valor a pagar : R${preco[a].ToString("N2")}. ");
                            Console.ResetColor();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Até a próxima!");
                        break;


                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }
                



            } while (escolha != 0);



            
            bool Login(string senha){
                if(senha == "123456"){
                    return false;
                }else{
                    return true;
                }

            }
            
            bool Descontar(string desconto){
                if(desconto == "sim"){
                    return true;
                }else{
                    return false;
                }

            }




        }
    }
}

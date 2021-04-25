using System;

namespace AtividadePassagensAéreas
{
    class Program
    {
        static void Main(string[] args)
        {   

            int escolha;
            int contador = 0;
            string resposta;
            bool senhaValida;
            string[] nomes = new string[5];
            string[] destino = new string [5];
            string[] origem = new string[5];
            string[] data = new string [5];

            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----Sistema de Passagens-----");
            Console.WriteLine("------------------------------");
            
            
            do
            {
               Console.WriteLine("Digite a senha para acessar o sistema");
               string senha = Console.ReadLine();
               senhaValida = EfetuarLogin(senha);
               
            } while (!senhaValida);


            do
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("-Cadastro de Passagens-");
                        do
                        {
                            if(contador < 5 ){
                            Console.WriteLine($"Digite o nome do {contador+1}º passageiro");
                            nomes[contador] = Console.ReadLine();

                            Console.WriteLine("Digite o destino do vôo");
                            destino[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a origem do vôo");
                            origem[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a data do vôo");
                            data[contador] = Console.ReadLine();
                            contador++;
                            }else{
                                Console.WriteLine("Limite excedido!");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar outro passageiro? S/N");
                            resposta = Console.ReadLine();
                           }while (resposta.ToUpper() == "S");
                           Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Listar passagens");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro: {nomes[i]} \tDestino: {destino[i]} \tOrigem: {origem[i]} \tData do voo: {data[i]}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por viajar conosco! Até a próxima ! ");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (escolha != 0);
            
                bool EfetuarLogin(string senha){
                    if (senha == "123456"){
                    return true;
                    }else{

                    Console.WriteLine("Senha inválida, Digite novamente!");
                    return false;
               }

            }

        }
    }
}

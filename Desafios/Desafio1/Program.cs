using System;
using Desafio1.Classes;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            int capacidade;
            int andares;
            int opcao;
            int pessoas;
            int remover;
            int subir;
            int descer;

            Console.WriteLine("Digite a capacidade do elevador");
            capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de andares do prédio");
            andares = int.Parse(Console.ReadLine());
            // elevador.Capacidade = capacidade;
            // elevador.TotalDeAndares = andares;
            elevador.Inicializar(capacidade, andares);

            do{

            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("[1] - Acrescentar pessoas no elevador ");
            Console.WriteLine("[2] - Remover pessoas do elevador ");
            Console.WriteLine("[3] - Subir andares ");
            Console.WriteLine("[4] - Descer andares ");
            Console.WriteLine("[0] - Sair ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"A capacidade do elevador é de {elevador.Capacidade}");
                    Console.WriteLine("Deseja acrescentar quantas pessoas no elevador? ");
                    pessoas = int.Parse(Console.ReadLine());
                    
                    if(pessoas <= elevador.Capacidade){
                        elevador.Entrar(pessoas);
                        Console.WriteLine($"Foram acrescentadas {pessoas} pessoas");
                        Console.WriteLine($"A quantidade de pessoas no elevador é {elevador.PessoasNoElevador} ");
                    }

                    else if(pessoas > elevador.Capacidade){
                        Console.WriteLine("A capacidade do elevador não permite esta quantidade de pessoas");
                    }

                    else if(elevador.PessoasNoElevador > elevador.Capacidade){
                        Console.WriteLine("A capacidade do elevador não permite esta quantidade de pessoas");
                    }

                    break;

                case 2:
                    Console.WriteLine($"Quantidade de pessoas no elevador {elevador.PessoasNoElevador} ");
                    Console.WriteLine("Deseja remover quantas pessoas do elevador?");
                    remover = int.Parse(Console.ReadLine());

                    if(remover <= elevador.PessoasNoElevador){
                        elevador.Sair(remover);
                        Console.WriteLine($"A quantidade de pessoas no elevador agora é: {elevador.PessoasNoElevador} pessoas ");
                    }
                    else if(remover > elevador.PessoasNoElevador){
                        Console.WriteLine("Não é possível remover esta quantidade de pessoas, pois tem menos pessoas no elevador");
                    }

                    break;

                case 3:
                    Console.WriteLine($"Andar atual do elevador {elevador.AndarAtual} ");
                    Console.WriteLine($"Quantidade de andares {elevador.TotalDeAndares}");
                    Console.WriteLine("Deseja subir quantos andares? ");
                    subir = int.Parse(Console.ReadLine());

                    if(subir <= elevador.TotalDeAndares){
                        elevador.Subir(subir);
                        Console.WriteLine("Aguarde...");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine($"Chegamos ao {elevador.AndarAtual}º andar");
                        Console.Beep(500, 1000);
                    }

                    else if(subir > elevador.TotalDeAndares){
                        Console.WriteLine("Não é possível subir para este andar");
                    }

                    else if(elevador.AndarAtual > elevador.TotalDeAndares){
                        Console.WriteLine("Não é possível subir para este andar");
                    }
                    
                    break;

                case 4:
                    Console.WriteLine($"Andar atual: {elevador.AndarAtual}º ");
                    Console.WriteLine("0º andar = Térreo");

                    Console.WriteLine($"Deseja descer quantos andares?");
                    descer = int.Parse(Console.ReadLine());

                    if(descer <= elevador.AndarAtual){
                        elevador.Descer(descer);
                        Console.WriteLine("Aguarde...");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine($"Chegamos ao {elevador.AndarAtual}º andar");
                        Console.Beep(500, 1000);
                    }


                    else if(descer > elevador.AndarAtual){
                        Console.WriteLine("Não é possível ir para este andar");
                    }

                    break;

                case 0:
                    Console.WriteLine();
                    break;



                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }
            
            } while(opcao != 0);


        }
    }
}

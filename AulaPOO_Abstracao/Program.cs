using System;
using AulaPOO_Abstracao.Classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {

            Credito credito = new Credito();
            Debito debito = new Debito();
            Boleto boleto = new Boleto();

            string resposta;
            int escolha;
            string registrarCred = "n";
            string registrarDeb = "";
            float valorCompra;
            string opcao;
            string tipoCartao;

            do{
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("---- Escolha uma opção ----");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Escolha uma opcão");
            Console.WriteLine("[1] - Registrar Cartão ");
            Console.WriteLine("[2] - Pagar produto ");
            Console.WriteLine("[3] - Dados de pagamento ");
            Console.WriteLine("[0] - SAIR ");
            escolha = int.Parse(Console.ReadLine());
            

            switch (escolha)
            {
                case 1:   
                    Console.WriteLine("Escolha uma opção\n[a] - Credito [b] - Debito ");
                    resposta = Console.ReadLine().ToLower();
                    
                    if(resposta == "a" ){

                        Console.WriteLine(credito.SalvarCartao());

                        Console.WriteLine("Deseja registrar esse cartão? s/n");
                        registrarCred = Console.ReadLine();

                        if(registrarCred == "s"){
                            Console.WriteLine("Cartão registrado com sucesso!");
                        }else{
                            Console.WriteLine("O cartão não foi registrado!");
                        }
                        
 
                    }
                    else if(resposta == "b"){

                        Console.WriteLine(debito.SalvarCartao());

                        Console.WriteLine("Deseja registrar este cartão? s/n ");
                        registrarDeb = Console.ReadLine();

                        if(registrarDeb == "s"){
                            Console.WriteLine("Cartão registrado com sucesso!");
                        }else{
                            Console.WriteLine("O cartão não foi registrado!");
                        }


                    }
                    else{
                        Console.WriteLine("Operação Inválida! Tente Novamente!");
                    }


                    break;

                case 2:
                    Console.Write("Digite o valor da compra: ");
                    valorCompra = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Escolha a opção de pagamento de pagamento\n[a] - Boleto [b] - Cartão ");
                    opcao = Console.ReadLine();
                    
                    switch (opcao)
                    {
                        case "a":
                            boleto.Registrar();
                            boleto.Valor = valorCompra;
                            boleto.Data = DateTime.Now;
                            boleto.GerarBoleto();
                            boleto.Cancelar();


                            break;

                        
                        case "b":
                            Console.WriteLine("Escolha uma opção\n[1] - Crédito [2] - Débito ");                        
                            tipoCartao = Console.ReadLine();

                            if(tipoCartao == "1"){
                                
                                if(registrarCred == "s"){
                                credito.Valor = valorCompra;
                                credito.Data = DateTime.Now;
                                credito.Pagar(credito.Valor);
                                credito.Cancelar();
                                }
                                else if(registrarCred == "n"){
                                    Console.WriteLine("Você deve registrar um cartão para fazer a compra");
                                }

                            }
                            if(tipoCartao == "2"){

                                if(registrarDeb == "s"){
                                    debito.Data = DateTime.Now;
                                    debito.Valor = valorCompra;
                                    debito.Pagar(debito.Valor);
                                    debito.Cancelar();
                                }

                            }

                            break;



                        default:
                            break;
                    }
                     


                    break;


                case 3:
                    Console.WriteLine("Cartão de Crédito");
                    Console.WriteLine($"Bandeira {credito.bandeira} ");
                    Console.WriteLine($"Numero: {credito.numero} ");
                    Console.WriteLine($"Titular: {credito.titular}  ");
                    Console.WriteLine($"CVV: {credito.cvv} ");

                    Console.WriteLine("-----------------------------");

                    Console.WriteLine("Cartão de Débito");
                    Console.WriteLine($"Bandeira: {debito.bandeira} ");
                    Console.WriteLine($"Numero: {debito.numero} ");
                    Console.WriteLine($"Titular: {debito.titular} ");
                    Console.WriteLine($"CVV: {debito.cvv} ");



                    break;




                case 0:
                    Console.WriteLine("Até a próxima!");
                    break;

                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }
                
            




            }while (escolha != 0);




        }
    }
}


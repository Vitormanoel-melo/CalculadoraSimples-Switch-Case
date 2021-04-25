using System;
using AulaPOO_Heranca.Classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            bool documento = false;

            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite seu nome");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine(pessoa.DarBoasVindas(pessoa.nome));



            Console.WriteLine("Escolha uma opção\n[a] - Pessoa Física\n[b] - Pessoa Jurídica");
            resposta = Console.ReadLine();


            PessoaFisica pessoa1 = new PessoaFisica();

            if(resposta == "a"){
                
                do{

                    Console.Write("Digite o CPF: ");
                    pessoa1.cpf = Console.ReadLine();

                    documento = pessoa1.ValidarCpf(pessoa1.cpf);
                        
                    if(documento == false){
                        Console.WriteLine("CPF Inválido");
                    }


                }while(documento == false);

                do{

                    Console.Write("Digite o RG: ");
                    pessoa1.rg = Console.ReadLine();

                    documento = pessoa1.ValidarRg(pessoa1.rg);
                        
                    if(documento == false){
                        Console.WriteLine("RG Inválido");
                    }


                }while(documento == false);


                Console.Write("Digite o nome: ");
                pessoa1.nome = Console.ReadLine();

                Console.WriteLine($"Nome: {pessoa1.nome}");
                Console.WriteLine($"CPF: {pessoa1.cpf}");
                Console.Write($"RG: {pessoa1.rg} ");

            }

            PessoaJuridica pessoa2 = new PessoaJuridica();

            if(resposta == "b"){
                do{
                    Console.WriteLine("Digite o CPNJ");
                    pessoa2.cnpj = Console.ReadLine();

                    documento = pessoa2.ValidarCnpj(pessoa2.cnpj);

                    if(documento == false){
                        Console.WriteLine("CNPJ Inválido");
                    }

                }while(documento == false);


                do{
                    Console.WriteLine("Digite a inscrição estadual");
                    pessoa2.inscricaoEstadual = Console.ReadLine();

                    documento = pessoa2.ValidarInscricao(pessoa2.inscricaoEstadual);

                    if(documento == false){
                        Console.WriteLine("Inscrição estadual Inválida");
                    }

                }while(documento == false);

                Console.WriteLine($"CNPJ: {pessoa2.cnpj} ");
                Console.WriteLine($"Inscrição Estadual: {pessoa2.inscricaoEstadual} ");


            }




        }
    }
}

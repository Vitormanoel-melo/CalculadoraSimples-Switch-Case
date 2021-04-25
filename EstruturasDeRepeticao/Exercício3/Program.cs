using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome="";

            do{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Digite seu nome: ");

                Console.ForegroundColor = ConsoleColor.Gray;
                nome = Console.ReadLine();

                if(nome == ""){
                    Console.WriteLine("Você não pode deixar seu nome em branco!");
                }
            }while(nome == "");

            Console.WriteLine("------------------------");


            int idade = 0;

            do{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Digite sua idade (apenas números): ");

                Console.ForegroundColor = ConsoleColor.Gray;
                idade = int.Parse(Console.ReadLine());

                if(idade < 0 || idade > 150 ){
                    Console.WriteLine("Idade não permitida! Sua idade deve ser entre 0 e 150 anos");
                }
            }while(idade < 0 || idade > 150 );


            Console.WriteLine("------------------------");


            double salario = 0;

            do{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Digite o valor de seu sálario (apenas números): ");

                Console.ForegroundColor = ConsoleColor.Gray;
                salario = double.Parse(Console.ReadLine());

                if(salario <= 0){
                    Console.WriteLine("Salário não permitido! Seu salário deve ser acima de 0 reais ");
                }
            }while(salario <= 0);


            Console.WriteLine("------------------------");


            string estadoCivil = "";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite seu estado civil: \nSolteiro(a), Casado(a), Viuvo(a), Divorciado(a) ");

            Console.ForegroundColor = ConsoleColor.Gray;
            estadoCivil = Console.ReadLine().ToLower();

            switch(estadoCivil){
                case "solteiro":
                    estadoCivil = "solteiro";
                    break;

                case "solteira":
                    estadoCivil = "solteira";
                    break;

                case "casado":
                    estadoCivil = "casado";
                    break;

                case "casada":
                    estadoCivil = "casada";
                    break;

                case "viuvo":
                    estadoCivil = "viuvo";
                    break;

                case "divorciado":
                    estadoCivil = "divorciado";
                    break;

                case "divorciada":
                    estadoCivil = "divorciada";
                    break;

                default:
                    Console.WriteLine("Operação inválida! Você deve digitar um dos estados civis mostrados!");
                    break;
            }

            Console.WriteLine($" Nome: {nome}\n Idade: {idade}\n Salário: {salario}\n Estado Civil: {estadoCivil}\n  ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro realizado com sucesso!");

        }
    }
}

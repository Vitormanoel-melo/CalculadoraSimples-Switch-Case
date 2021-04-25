using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            
            Console.Write("Digite a quantidade do produto (apenas números): ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário do produto (apenas números): "); 
            float preco = float.Parse(Console.ReadLine());
    
            float valor = 0;
            float resultado = 0;


            valor = quantidade * preco;

            if(quantidade <= 5){
                Resultado1(resultado, valor);
            }
            else if(quantidade >5 && quantidade <=10){
                Resultado2(resultado, valor);                
            }
            else{
                Resultado3(resultado, valor);
            }

            Console.WriteLine($"Produto: {nome}. \tTotal a pagar: {resultado.ToString("N2")} ");
            
            float Resultado1(float r, float v){
                resultado = valor - (valor * 0.02f);
                return resultado;
            }

            float Resultado2(float r, float v){
                resultado = valor - (valor * 0.03f);
                return resultado;
            }

            float Resultado3(float r, float v){
                resultado = valor - (valor * 0.05f);
                return resultado;

            }

        }

    }
}

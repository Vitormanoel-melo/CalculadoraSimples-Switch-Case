using System;

namespace ExercícioMédiaDosAlunos
{
    class Program
    {
        static float CalculoMedia( float[] nota){

            float soma = 0;

            for (var i = 0; i < nota.Length; i++)
            {
                soma += nota[i];

            }

            float resultado = soma / nota.Length;

            return resultado;

        }


        static void Main(string[] args)
        {
            string[] nomes = new string[2];
            float[] medias = new float[2];
            float[] notas = new float[2];


            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine( $" Digite o nome do {i+1}º aluno: " );
                nomes[i] = Console.ReadLine();

                for (var nota = 0; nota < notas.Length; nota++)
                {
                    Console.WriteLine( $" Digite a {nota+1}° nota ");
                    notas[nota] = float.Parse(Console.ReadLine());
                }
                medias[i]  = CalculoMedia(notas);
            }
            for (var i = 0; i < nomes.Length; i++)
            {       
  

                if(CalculoMedia(medias) < 7){
                    Console.WriteLine($"Nome: {nomes[i]}  Média: {medias[i]}  Situação: Reprovado");
                }
                if(CalculoMedia(medias) >= 7){
                    Console.WriteLine($"Nome: {nomes[i]}  Média: {medias[i]}  Situação: Aprovado");
                }

            }




        }
    }
}

namespace POO_Static
{
    public static class Conversor
    {
        
        public static float cotacaoDolar = 5.10f ;

        public static float cotacaoEuro = 6.21f;

        public static float valorUsuario;

        public static float ConverterDolarParaReal(){

            return valorUsuario * cotacaoDolar;
        }

        public static float ConverterRealParaDolar(){

            return valorUsuario / cotacaoDolar;
        }

        public static float ConverterEuroParaReal(){

            return valorUsuario * cotacaoEuro;
        }

        public static float ConverterRealParaEuro(){

            return valorUsuario / cotacaoEuro;
        }



    }
}
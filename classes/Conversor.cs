using System;

namespace POO_Classes_Metodos_Atributos_Est_ticos.classes
{
    public static class Conversor
    {
        private static float cotaDolar = 5.12f;
        private static float cotaEuro = 6.22f;

        public static float RealParaDolar(float valorRS)
        {
            return valorRS / cotaDolar;
        }

        public static float RealparaEuro(float valorRS)
        {
            return valorRS / cotaEuro;
        }
        public static float DolarParaReais(float valorUSD)
        {
            return cotaDolar * valorUSD;
        }
        public static float EuroParaReal(float valorEUR)
        {
            return cotaEuro * valorEUR;
        }
    }
}
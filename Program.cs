using System;
using POO_Classes_Metodos_Atributos_Est_ticos.classes;

namespace POO_Classes_Metodos_Atributos_Est_ticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReais(1));
            Console.WriteLine(Conversor.RealParaDolar(1));
            Console.WriteLine(Conversor.EuroParaReal(1));
            Console.WriteLine(Conversor.RealparaEuro(1));
        }
    }
}

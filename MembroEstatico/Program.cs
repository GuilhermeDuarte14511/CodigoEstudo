using System;
using System.Globalization;
namespace MembroEstatico
{
    class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("Entre o Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio);
            double voulme = Calculadora.Volume(raio);
       
           Console.WriteLine("Circuferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));
           Console.WriteLine("Volume: " + voulme.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi);

        }



       
    }

}
 
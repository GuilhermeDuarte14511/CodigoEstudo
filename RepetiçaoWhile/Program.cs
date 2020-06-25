using System;
using System.Globalization;

namespace RepetiçaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            Console.WriteLine("Digite Qual Combustivel quer Abastecer: ");
            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if(tipo == 1) {
                    Alcool = Alcool + 1;
                }
                else if( tipo == 2)
                {
                    Gasolina = Gasolina + 1;
                }
                else if ( tipo == 0)
                {
                    Diesel = Diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);


        }
    }
}
﻿using System;
using System.Globalization;
namespace LadosTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre Com as Medidas do Triangulo X: ");
           x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre Com as Medidas do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {

                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}

using System;

namespace OperadoresComparativos
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            bool c11 = a < 10;
            bool c12 = a < 20;
            bool c13 = a > 10;
            bool c14 = a > 5;
            


            Console.WriteLine(c11);
            Console.WriteLine(c12);
            Console.WriteLine(c13);
            Console.WriteLine(c14);

            Console.WriteLine("------------------------------------------");

            bool c15 = a <= 10;
            bool c16 = a >= 10;
            bool c17 = a == 10;
            bool c18 = a != 10;
            
            Console.WriteLine(c15);
            Console.WriteLine(c16);
            Console.WriteLine(c17);
            Console.WriteLine(c18);

            Console.WriteLine("------------------------------------------");


            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = ! (2 > 3) || 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
           
            Console.WriteLine("------------------------------------------");

            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }
    }
}

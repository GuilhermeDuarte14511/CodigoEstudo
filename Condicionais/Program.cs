using System;
using System.ComponentModel.Design;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o Numero Inteiro");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {

                Console.WriteLine("Par!");

            }
            else
            {
                Console.WriteLine("Impar!");

                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Qual a Hora Atual?");
                int hora = int.Parse(Console.ReadLine());

                if (hora < 12)
                {
                    Console.WriteLine("Bom Dia");
                }
                else if (hora < 18)
                {
                    Console.WriteLine("Boa Tarde");
                }
                else
                {
                    Console.WriteLine("Boa Noite");
                }
            }
        }
    }
}

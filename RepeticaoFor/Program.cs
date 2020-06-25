using System;

namespace RepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Numeros você Quer Digitar?: ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor : #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }

            Console.WriteLine("Soma = " + soma);

        }
    }
}

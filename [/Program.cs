using System;
using System.Globalization;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R$ {saldo:F2}" + " reais");


            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual á R$" + saldo.ToString("F2") + " reais");

            string produto1 = "Computador";
            string produto2 = " Mesa de escritório";

            byte idade2 = 30;
            int codigo = 5290;
            string genero = "M";

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //Console.WriteLine(produto1 + " cujo o preço é R$" + preco1);
            //Console.WriteLine(produto2 + " cujo o preco é R$" + preco2);


            Console.WriteLine(" Registro " + idade2 + codigo + " e " + genero);

            Console.WriteLine(" a medida é de {medidaF:2");
}
            


        }

    }


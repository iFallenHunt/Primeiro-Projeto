using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod1 = "Computador";
            string prod2 = "Mesa de escritório";

            byte idade = 25;
            int codigo = 5290;
            char genero = 'F';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{prod1}, cujo o preço é de R$ {preco1}");
            Console.WriteLine($"{prod2}, cujo o preço é de R$ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} Anos de idade, código {codigo} e gênero:{genero} ");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimáis: {preco3}");
            Console.WriteLine($"Medida arredondada {preco3:F3}");
            Console.WriteLine("Medida com separador decimal " + preco3.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

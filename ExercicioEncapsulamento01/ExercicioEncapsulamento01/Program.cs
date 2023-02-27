using System;
using System.Globalization;

namespace ExercicioEncapsulamento01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.00, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "Thiago";
            Console.WriteLine(p.Nome);
        }
    }
}
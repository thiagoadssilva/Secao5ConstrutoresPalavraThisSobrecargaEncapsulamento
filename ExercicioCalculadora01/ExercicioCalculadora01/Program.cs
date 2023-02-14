using System;
using System.Globalization;

namespace ExercicioCalculadora01 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            int operacao;
            double numeroUm;
            double numeDois;

            Console.WriteLine("Bem vindo a sua calculadora");
            Console.WriteLine();

            Console.WriteLine("Informe o primeiro numero");
            numeroUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Informe a sua operação (1 - Somar, 2 - Dividir, 3 - Multiplicar, 4 - Subtrair)");
            operacao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe o segundo numero");
            numeDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            if (operacao == 1) {
                double resultado = calc.Somar(numeroUm, numeDois);
                Console.WriteLine("O resultado da operação é: " + resultado);
            }

            if (operacao == 2)
            {
                double resultado = calc.Dividir(numeroUm, numeDois);
                Console.WriteLine("O resultado da operação é: " + resultado);
            }

            if (operacao == 3)
            {
                double resultado = calc.Multiplicar(numeroUm, numeDois);
                Console.WriteLine("O resultado da operação é: " + resultado);
            }

            if (operacao == 4)
            {
                double resultado = calc.Subtrair(numeroUm, numeDois);
                Console.WriteLine("O resultado da operação é: " + resultado);
            }

        }
    }
}
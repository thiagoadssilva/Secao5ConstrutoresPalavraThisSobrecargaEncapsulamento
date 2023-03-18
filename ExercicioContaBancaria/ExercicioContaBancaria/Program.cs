using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            int numero;
            double saldo;
            double SaldoInicial;
            string titular;
            string controleDeposito;

            Console.WriteLine("Entre o número da conta:");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta:");
            titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (S/N)?");
            controleDeposito = Console.ReadLine();

            if (controleDeposito == "S")
            {
                Console.WriteLine("Entre o valor de depósito inicial:");
                SaldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, SaldoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);


            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Entre um valor para depósito:");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados:");
            conta.Deposito(saldo);
            Console.WriteLine(conta);

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Entre um valor para saque:");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados:");
            conta.Saque(saldo);
            Console.WriteLine(conta);

            Console.WriteLine("----------------------------------------");


        }
    }
}
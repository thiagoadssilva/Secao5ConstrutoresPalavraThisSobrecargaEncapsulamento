using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaBancaria
{
    public class ContaBancaria
    {
       

        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double deposito) : this(numero, titular)
        {
            Deposito(deposito);
            //Saldo = saldo;
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade + 5.0;
        }

        public override string ToString()
        {
            return "Conta " 
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

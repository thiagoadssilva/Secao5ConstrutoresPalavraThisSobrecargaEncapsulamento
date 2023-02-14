using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculadora01
{
    public class Calculadora
    {
        public string Operacao;
        public double NumeroUm;
        public double NumeroDois;
        public double Resultado;

        public Calculadora()
        {
            NumeroUm = 0;
            NumeroDois = 0;
            Resultado = 0;
        }

        public Calculadora(string operacao) : this()
        {
            Operacao = operacao;
        }

        public double Somar(double n1, double n2)
        {
            Resultado = n1 + n2;
            return Resultado;
        }

        public double Dividir(double n1, double n2)
        {
            Resultado = n1 / n2;
            return Resultado;
        }

        public double Multiplicar(double n1, double n2)
        {
            Resultado = n1 * n2;
            return Resultado;
        }

        public double Subtrair(double n1, double n2)
        {
            Resultado = n1 - n2;
            return Resultado;
        }




    }
}

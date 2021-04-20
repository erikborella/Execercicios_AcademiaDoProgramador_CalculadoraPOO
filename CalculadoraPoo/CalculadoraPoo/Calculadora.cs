using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CalculadoraPoo
{
    class Calculadora
    {
        List<string> historico = new List<string>();

        public double Somar(double n1, double n2) {
            double resultado = n1 + n2;
            string conta = $"{n1} + {n2} = {resultado}";

            historico.Add(conta);

            return resultado;
        }

        public double Subtrair(double n1, double n2)
        {
            double resultado = n1 - n2;
            string conta = $"{n1} - {n2} = {resultado}";

            historico.Add(conta);

            return resultado;
        }

        public double Multiplicar(double n1, double n2)
        {
            double resultado = n1 * n2;
            string conta = $"{n1} * {n2} = {resultado}";

            historico.Add(conta);

            return resultado;
        }

        public double Dividir(double n1, double n2)
        {
            double resultado = n1 / n2;
            string conta = $"{n1} / {n2} = {resultado}";

            historico.Add(conta);

            return resultado;
        }

        public string[] PegarHistorico()
        {
            return historico.ToArray();
        }
    }
}

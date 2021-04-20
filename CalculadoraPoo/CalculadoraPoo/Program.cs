using System;

namespace CalculadoraPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            while (true)
            {
                int opcao = MenuDeOpcao("1. Somar\n" +
                    "2. Subtrair\n" +
                    "3. Multiplicar\n" +
                    "4. Dividir\n" +
                    "5. Ver Historico\n" +
                    "6. Sair\n" +
                    "Digite o que deseja fazer: ",
                    "Voce digitou uma operação incorreta, tente novamente",
                    1, 6);

                if (opcao == 5)
                {
                    VerHistorico(calculadora);
                    continue;
                }

                if (opcao == 6)
                {
                    break;
                }

                double n1, n2;

                n1 = LerDouble("Primeiro");

                while (true)
                {
                    n2 = LerDouble("Segundo");

                    if (opcao == 4 && n2 == 0)
                    {
                        Console.WriteLine("Voce não pode dividir por 0");
                        continue;
                    }
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        calculadora.Somar(n1, n2);
                        break;
                    case 2:
                        calculadora.Subtrair(n1, n2);
                        break;
                    case 3:
                        calculadora.Multiplicar(n1, n2);
                        break;
                    case 4:
                        calculadora.Dividir(n1, n2);
                        break;
                }
                ImprimirUltimaContaConta(calculadora);
            }
        }

        private static void VerHistorico(Calculadora calculadora)
        {
            Console.Clear();
            string[] historico = calculadora.PegarHistorico();
            if (historico.Length == 0)
            {
                Console.WriteLine("Voce não tem nenhuma conta feita, faça alguma!");
            }
            foreach(string conta in historico)
            {
                Console.WriteLine(conta);
            }
            Pausar();
        }

        private static void ImprimirUltimaContaConta(Calculadora calculadora)
        {
            Console.Clear();
            string[] historico = calculadora.PegarHistorico();
            Console.WriteLine(historico[historico.Length - 1]);
            Pausar();
            Console.Clear();

        }

        private static double LerDouble(string ordem)
        {
            bool numeroLidoEhNumero = false;
            double numero = 0.0;

            do
            {
                Console.Write($"Digite o {ordem} numero: ");
                string numeroString = Console.ReadLine();
                numeroLidoEhNumero = double.TryParse(numeroString, out numero);

                if (!numeroLidoEhNumero)
                {
                    Console.WriteLine("Por Favor, Digite um numero!");
                }

            } while (!numeroLidoEhNumero);

            return numero;
        }

        private static bool OpcaoEstaCorreta(int opMin, int opMax, int op)
        {
            return (op >= opMin && op <= opMax);
        }

        private static int MenuDeOpcao(string msg, string erroMsg, int opMin, int opMax)
        {
            int opcao = opMin - 1;

            while (opcao <= opMin - 1)
            {
                Console.Write(msg);
                opcao = Convert.ToInt32(Console.ReadLine());

                if (!OpcaoEstaCorreta(opMin, opMax, opcao))
                {
                    Console.WriteLine(erroMsg);
                    opcao = opMin - 1;
                }
            }

            return opcao;
        }

        private static void Pausar()
        {
            Console.WriteLine("\nDigite qualquer coisa para continuar: ");
            Console.ReadLine();
        }
    }
}

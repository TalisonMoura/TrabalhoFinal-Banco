using System;
using System.Globalization;
using TrabalhoFinalBanco.Entities;

namespace TrabalhoFinalBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Entre com o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o número da Conta Corrente: ");
            int numContaCorrente = int.Parse(Console.ReadLine());
            Console.Write($"Entre com o saldo inicial da Conta Corrente {numContaCorrente}: ");
            double saldoInicialCorrente = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine("");

            Console.Write("Entre com o número da Conta Poupança: ");
            int numContaPoupanca = int.Parse(Console.ReadLine());
            Console.Write($"Entre com o saldo inicial da Conta Poupança {numContaPoupanca}: ");
            double saldoInicialPoupanca = double.Parse(Console.ReadLine(), ci);

            int opcao = 0;
            int escolha = 0;
            double saldo = 0; /* Este saldo é o que está sendo usado para armazenar calculos entre os saldos das respectivas contas escolhidas */
            double valor = 0;
            double saldoFinal = 0;

            do
            {
                Console.WriteLine("Qual operação deseja realizar?");
                Console.WriteLine("1 - Creditar\n" +
                                  "2 - Debitar\n" +
                                  "3 - Transferir\n" +
                                  "4 - Saldo\n" +
                                  "5 - Sair");
                Console.WriteLine("");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Em qual conta:");
                        Console.WriteLine("1 - Corrente\n" +
                                          "2 - Poupança");
                        escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Console.Write($"Qual valor a creditar na conta corrente {numContaCorrente}: ");
                            valor = int.Parse(Console.ReadLine(), ci);
                            saldo = valor + saldoInicialCorrente;
                            ContaCorrente contaCorrente = new ContaCorrente(numContaCorrente, saldo);
                            Console.WriteLine(contaCorrente);
                            Console.WriteLine("");
                        }
                        else if (escolha == 2)
                        {
                            Console.Write($"Qual valor a creditar na conta poupança {numContaPoupanca}: ");
                            valor = int.Parse(Console.ReadLine(), ci);
                            saldo = valor + saldoInicialPoupanca;
                            ContaPoupanca contaPoupanca = new ContaPoupanca(numContaCorrente, saldo);
                            Console.WriteLine(contaPoupanca);
                            Console.WriteLine("");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Em qual conta:");
                        Console.WriteLine("1 - Corrente\n" +
                                          "2 - Poupança");
                        escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Console.Write($"Qual valor a debitar na conta corrente {numContaCorrente}:");
                            valor = int.Parse(Console.ReadLine(), ci);
                            saldo = valor - saldoInicialCorrente;
                            ContaCorrente contaCorrente = new ContaCorrente(numContaCorrente, saldo);
                            Console.WriteLine(contaCorrente);
                            Console.WriteLine("");
                        }
                        else if (escolha == 2)
                        {
                            Console.Write($"Qual valor a debitar na conta poupança {numContaPoupanca}:");
                            valor = int.Parse(Console.ReadLine(), ci);
                            saldo = valor + saldoInicialPoupanca;
                            if (valor > saldo)
                            {
                                Console.WriteLine("Saldo Insuficiente");
                                Console.WriteLine(saldo);
                                Console.WriteLine("");
                            }
                            else
                            {
                                saldo = valor - saldoInicialCorrente;
                                ContaPoupanca contaPoupanca = new ContaPoupanca(numContaCorrente, saldo);
                                Console.WriteLine(contaPoupanca);
                                Console.WriteLine("");
                            }
                        }
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;
                }

            } while (opcao != 5);

        }
    }
}
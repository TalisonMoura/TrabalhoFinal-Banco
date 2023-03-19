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
            ContaCorrente contaCorrente = new ContaCorrente(numContaCorrente);
            Console.Write($"Entre com o saldo inicial da Conta Corrente {numContaCorrente}: ");
            double saldoInicialCorrente = double.Parse(Console.ReadLine(), ci);
            contaCorrente.AdicionarSaldo(saldoInicialCorrente);


            Console.WriteLine("");

            Console.Write("Entre com o número da Conta Poupança: ");
            int numContaPoupanca = int.Parse(Console.ReadLine());
            ContaPoupanca contaPoupanca = new ContaPoupanca(numContaPoupanca);
            Console.Write($"Entre com o saldo inicial da Conta Poupança {numContaPoupanca}: ");
            double saldoInicialPoupanca = double.Parse(Console.ReadLine(), ci);
            contaPoupanca.AdicionarSaldo(saldoInicialPoupanca);

            int opcao = 0;
            int escolha = 0;
            double saldoPoupanca = 0;
            double saldoCorrente = 0;
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
                            valor = double.Parse(Console.ReadLine(), ci);
                            contaCorrente.AdicionarSaldo(valor);
                            Console.WriteLine(contaCorrente);
                            Console.WriteLine("");
                        }
                        else if (escolha == 2)
                        {
                            Console.Write($"Qual valor a creditar na conta poupança {numContaPoupanca}: ");
                            valor = double.Parse(Console.ReadLine(), ci);
                            contaPoupanca.AdicionarSaldo(valor);
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
                            Console.Write($"Qual valor a debitar na conta corrente {numContaCorrente}: ");
                            valor = double.Parse(Console.ReadLine());
                            saldoFinal = contaCorrente.Saldo - valor;
                            contaCorrente.RemoverSaldo(saldoFinal);
                            Console.WriteLine(contaCorrente);
                            Console.WriteLine("");
                        }
                        else if (escolha == 2)
                        {
                            Console.Write($"Qual valor a debitar na conta poupança {numContaPoupanca}: ");
                            valor = double.Parse(Console.ReadLine(), ci);
                            if (contaPoupanca.Saldo < valor)
                            {
                                Console.WriteLine("Saldo Insuficiente");
                                Console.WriteLine(contaPoupanca);
                                Console.WriteLine("");
                            }
                            else
                            {
                                saldoFinal = contaPoupanca.Saldo - valor;
                                contaPoupanca.RemoverSaldo(saldoFinal);
                                Console.WriteLine(contaPoupanca);
                                Console.WriteLine("");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Transferência entre:");
                        Console.WriteLine("1 - Conta Corrente e Poupança\n" +
                                          "2 - Conta Poupança e Corrente");
                        escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Console.Write($"Qual valor a transferir da Conta Corrente{numContaCorrente} para Conta Poupança {numContaPoupanca}: ");
                            valor = int.Parse(Console.ReadLine(), ci);

                            if (valor > saldoCorrente)
                            {
                                Console.WriteLine("Saldo Insuficiente");
                            }
                            else
                            {
                                saldoFinal = valor - saldoCorrente;
                                saldoPoupanca += saldoFinal;
                                Console.WriteLine(contaCorrente);
                                Console.WriteLine(contaPoupanca);
                            }
                        }
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
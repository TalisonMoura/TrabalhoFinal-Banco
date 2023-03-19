using System;
using System.ComponentModel.Design;
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
            Cliente cliente = new Cliente(nome);

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
            double valor = 0.0;

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
                            contaCorrente.RemoverSaldo(valor);
                            Console.WriteLine(contaCorrente);
                            Console.WriteLine("");
                        }
                        else if (escolha == 2)
                        {
                            Console.Write($"Qual valor a debitar na conta poupança {numContaPoupanca}: ");
                            valor = double.Parse(Console.ReadLine(), ci);
                            if (contaPoupanca.Saldo > valor)
                            {
                                contaPoupanca.RemoverSaldo(valor);
                                Console.WriteLine(contaPoupanca);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Saldo Insuficiente");
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
                            Console.Write($"Qual valor a transferir da Conta Corrente {numContaCorrente} para Conta Poupança {numContaPoupanca}: ");
                            valor = double.Parse(Console.ReadLine(), ci);

                            if (contaCorrente.Saldo > valor)
                            {
                                contaCorrente.RemoverSaldo(valor);
                                contaPoupanca.AdicionarSaldo(valor);
                                Console.WriteLine(contaCorrente);
                                Console.WriteLine(contaPoupanca);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Saldo Insuficiente");
                                Console.WriteLine(contaCorrente);
                                Console.WriteLine(contaPoupanca);
                                Console.WriteLine("");
                            }
                        }
                        else if (escolha == 2)
                        {
                            Console.Write($"Qual valor a transferir da Conta Poupança {numContaPoupanca} para Conta Corrente {numContaCorrente}: ");
                            valor = double.Parse(Console.ReadLine(), ci);
                            if (contaPoupanca.Saldo > 0)
                            {
                                if (contaPoupanca.Saldo > valor)
                                {
                                    contaPoupanca.RemoverSaldo(valor);
                                    contaCorrente.AdicionarSaldo(valor);
                                    Console.WriteLine(contaPoupanca);
                                    Console.WriteLine(contaCorrente);
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("Saldo Insuficiente");
                                    Console.WriteLine(contaPoupanca);
                                    Console.WriteLine(contaCorrente);
                                    Console.WriteLine("");
                                }
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine(cliente);
                        Console.WriteLine(contaCorrente);
                        Console.WriteLine(contaPoupanca);
                        Console.WriteLine("");
                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine($"{cliente}, Muito Obrigado(a) por ultilizar nossos serviços!");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção correta!");
                        Console.WriteLine("");
                        break;
                }
            } while (opcao != 5);
        }
    }
}
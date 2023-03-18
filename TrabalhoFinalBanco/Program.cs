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
            double saldoInicialCorrente = double.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            Console.Write("Entre com o número da Conta Poupança: ");
            int numContaPoupança = int.Parse(Console.ReadLine());
            Console.Write($"Entre com o saldo inicial da Conta Poupança {numContaPoupança}: ");
            double saldoInicialPoupança = double.Parse(Console.ReadLine());


            Cliente cliente = new Cliente(nome);
            ContaCorrente contaCorrente = new ContaCorrente(numContaCorrente,saldoInicialCorrente);
            ContaPoupança contaPoupança = new ContaPoupança(numContaPoupança, saldoInicialPoupança);
            

        }
    }
}
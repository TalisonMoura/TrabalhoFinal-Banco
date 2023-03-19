using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalBanco.Entities
{
    internal class ContaPoupanca
    {
        /* A conta poupança nunca aceitará saldo negativo */

        CultureInfo ci = CultureInfo.InvariantCulture;

        public int NumConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaPoupanca(int numConta)
        {
            NumConta = numConta;
        }
        public void AdicionarSaldo(double valor)
        {
            Saldo += valor;
        }
        public void RemoverSaldo(double valor)
        {
            Saldo -= valor;
        }
        public override string ToString()
        {
            return ($"Saldo atual na Conta Poupança {NumConta}: R${Saldo.ToString("F2", ci)}");
        }
    }
}

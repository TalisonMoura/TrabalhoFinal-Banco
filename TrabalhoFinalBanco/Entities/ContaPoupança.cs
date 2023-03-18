using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalBanco.Entities
{
    internal class ContaPoupança
    {
        /* A conta poupança nunca aceitará saldo negativo */

        public int NumConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaPoupança(int numConta, double saldo)
        {
            NumConta = numConta;
            Saldo = saldo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalBanco.Entities
{
    internal class ContaCorrente
    {
        /* O saldo da conta corrente não pode ficar negativo */

        CultureInfo ci = CultureInfo.InvariantCulture;

        public int NumConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaCorrente(int numConta, double saldo)
        {
            NumConta = numConta;
            Saldo = saldo;
        }
        public override string ToString()
        {
            return ($"Saldo atual na Conta Corrente {NumConta}: R${Saldo.ToString("F2", ci)}");
        }
    }
}

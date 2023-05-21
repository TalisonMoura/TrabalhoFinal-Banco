using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TrabalhoFinalBanco.Service;

namespace TrabalhoFinalBanco.Entities
{
    public class ContaCorrente : IConta
    {
        /* O saldo da conta corrente pode ficar negativo */

        CultureInfo ci = CultureInfo.InvariantCulture;

        public int NumConta { get => _NumConta ; set => _NumConta = value; }
        private int _NumConta;
        public double Saldo { get => _Saldo; set => _Saldo = value; }
        private double _Saldo;

        public ContaCorrente(int _NumConta)
        {
            NumConta = _NumConta;
        }

        public void AdicionarSaldo(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("Insira um valor válido!");
            }
            else
            {
                _Saldo += valor;
            }
        }
        public void RemoverSaldo(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Insira um valor válido!");
            }
            else
            {
                _Saldo -= valor;
            }
        }
        public override string ToString()
        {
            return ($"Saldo atual na Conta Corrente {NumConta}: R${Saldo.ToString("F2", ci)}");
        }
    }
}

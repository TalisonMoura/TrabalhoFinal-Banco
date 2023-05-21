using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalBanco.Service;

namespace TrabalhoFinalBanco.Entities
{
    internal class ContaPoupanca : IConta
    {
        /* A conta poupança nunca aceitará saldo negativo */

        CultureInfo ci = CultureInfo.InvariantCulture;

        public int NumConta { get => _NumConta; set => _NumConta = value; }
        private int _NumConta;
        public double Saldo { get => _Saldo; set => _Saldo = value; }
        private double _Saldo;
        
        public ContaPoupanca(int _NumConta)
        {
            NumConta = _NumConta;
        }
        public void AdicionarSaldo(double valor)
        {
            if (valor <= 0)
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
            return ($"Saldo atual na Conta Poupança {NumConta}: R${Saldo.ToString("F2", ci)}");
        }
    }
}

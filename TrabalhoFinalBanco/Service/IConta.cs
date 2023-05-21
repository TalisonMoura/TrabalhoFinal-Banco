using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalBanco.Service
{
    public interface IConta
    {
        public int NumConta { get; set; }
        public double Saldo { get; set; }
        protected virtual void AdicionarSaldo(double valor) { }
        protected virtual void RemoverSaldo(double valor) { }
    }
}

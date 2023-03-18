using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalBanco.Entities
{
    internal class Cliente
    {
        public string Nome { get; private set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}

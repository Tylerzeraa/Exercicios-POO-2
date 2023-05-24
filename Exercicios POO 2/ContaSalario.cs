using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO_2
{
     class ContaSalario : IConta
    {
       

        public ContaSalario(Cliente? cliente)
        {
            numero = "";
            this.cliente = cliente;
        }

        public double saldo { get; set; }
        public string numero { get; set; }
        public Cliente cliente { get; set; }

        public double CalcularSaldo() { return saldo; }
        public void Sacar(double valor) { saldo -= valor; }
        public void Depositar(double valor) { saldo += valor; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO_2
{
     class Corrente : IConta
    {
        public double saldo { get; set; }
        public string numero { get; set; }
        public Cliente cliente { get; set; }

        private double taxa { get; set; }

        public double CalcularSaldo()
        {
            return saldo;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public double CalcularTaxa() 
        {
            return taxa;        
        }

        public decimal Salario { get; set; }


        public Corrente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Corrente(string? numero)
        {
            this.numero = numero;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações da Conta Corrente:");
            Console.WriteLine($"Número da Conta: {numero}");
            Console.WriteLine($"Saldo: R${saldo}");
            Console.WriteLine();
        }



        
    }
}

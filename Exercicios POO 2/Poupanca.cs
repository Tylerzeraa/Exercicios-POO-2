using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO_2
{
     class Poupanca : IConta
    {
        public Poupanca(Cliente cliente)
        {
            //numero = numero_conta_poupança;
            this.cliente = cliente;
        }
        public double saldo { get; set; }
        public string numero { get; set; }
        public Cliente cliente { get; set; }

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

        public void Cliente(string nome, string cpf)
        {
           Console.WriteLine("Digite o nome do cliente");
           nome = Console.ReadLine();

           Console.WriteLine("Digite o CPF");
            cpf = Console.ReadLine(); 
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

using Exercicios_POO_2;
public static class program
{
    static List<IConta> Contas = new ();
    public static void Main()
    {
        MenuInicial();
    }

    static void MenuInicial()
    {
        int opcao;
        do
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Cadastrar cliente");
            Console.WriteLine("2. Exibir informações da conta");
            Console.WriteLine("3. Realizar depósito");
            Console.WriteLine("4. Realizar retirada");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 2:
                    ExibirInformacoesConta();
                    break;
                case 3:
                    RealizarDeposito();
                    break;
                case 4:
                    RealizarRetirada();
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    Console.WriteLine();
                    break;
            }
        } while (opcao != 5);

    }

    static void CadastrarCliente()
    {
        Console.Write("Digite o nome do cliente: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o CPF do cliente: ");
        string cpf = Console.ReadLine();
        Console.WriteLine("Selecione o tipo de conta:");
        Console.WriteLine("1. Conta Corrente");
        Console.WriteLine("2. Conta Poupança");
        Console.WriteLine("3. Conta Salário");
        Console.Write("Opção: ");
        int tipoConta = int.Parse(Console.ReadLine());
        Cliente novoCliente = new Cliente(nome, cpf);
        IConta conta;
        switch (tipoConta)
        {
            case 1:
                conta = new Corrente(novoCliente);
                break;
            case 2:
                conta = new Poupanca(novoCliente);
                break;
            case 3:
                conta = new ContaSalario(novoCliente);
                break;
            default:
                Console.WriteLine("Opção inválida. Cadastro cancelado.");
                Console.WriteLine();
                return;
        }

       
        Contas.Add(conta);

        Console.WriteLine("Conta cadastrada com sucesso!");
        Console.WriteLine();
    }

    static void ExibirInformacoesConta()
    {
        Console.Write("Digite o CPF do cliente: ");
        string cpf = Console.ReadLine();

        int clienteIndex = Contas.FindIndex(c => c.cliente.Cpf.Equals(cpf));

        if (clienteIndex != -1)
        {
            Contas[clienteIndex].cliente.ExibirInformacoes();
            Console.WriteLine($"Saldo da conta: R$ {Contas[clienteIndex].CalcularSaldo()}.");
        }
        else
        {
            Console.WriteLine("Cliente não encontrado.");
            Console.WriteLine();
        }
    }
    static void RealizarDeposito()
    {
        Console.Write("Digite o CPF do cliente: ");
        string cpf = Console.ReadLine();

        int index_conta = Contas.FindIndex(c => c.cliente.Cpf.Equals(cpf));
        if (index_conta == -1)
        {
            Console.WriteLine("Cliente não encontrado.");
            Console.WriteLine();
        }
        else
        {
            Console.Write("Valor a depositar: ");
            double valor = double.Parse(Console.ReadLine());
            Contas[index_conta].Depositar(valor);
            
            Console.WriteLine($"Deposito de R$ {valor} efetuado com sucesso.");
            Console.WriteLine($"Saldo da conta: R$ {Contas[index_conta].CalcularSaldo()}.");

        }
    }
    static void RealizarRetirada()
    {
        Console.Write("Digite o CPF do cliente: ");
        string cpf = Console.ReadLine();

        int index_conta = Contas.FindIndex(c => c.cliente.Cpf.Equals(cpf));
        if (index_conta == -1)
        {
            Console.WriteLine("Cliente não encontrado.");
            Console.WriteLine();
        }
        else
        {
            Console.Write("Valor a sacar: ");
            double valor = double.Parse(Console.ReadLine());
            Contas[index_conta].Sacar(valor);

            Console.WriteLine($"Saque de R$ {valor} efetuado com sucesso.");
            Console.WriteLine($"Saldo da conta: R$ {Contas[index_conta].CalcularSaldo()}.");
        }
    }
}
 

     



 

  

 

 

namespace Exercicios_POO_2
{
      class Cliente 
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }


        public Cliente(string nome, string cpf) 
        {
            Nome = nome;
            Cpf = cpf;
            
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações da Conta Corrente:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF:  {Cpf}");
         
            Console.WriteLine();
        }

      

    }
}
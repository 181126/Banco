using Banco.Classes;

class Program
{
	static void Main(string[] args)
	{ 
		Console.WriteLine("Escolha uma opção: " + "\n1- Conta Empresarial \n2- Conta Estudantil");
		int resposta1 = Convert.ToInt32(Console.ReadLine());

            if (resposta1 == 1)
            {
                ContaEmpresarial cEmpresa = new ContaEmpresarial("123", "002", "Renato", 50, 3000, 5, 0);

                Console.WriteLine("Escolha uma opção: " + "\n1- Saque \n2- Depósito \n3-Empréstimo");
                int resposta2 = Convert.ToInt32(Console.ReadLine());

                if (resposta2 == 1)
                {
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    cEmpresa.Sacar(valor);
                }
                else if (resposta2 == 2)
                {
                    Console.WriteLine("Digite o valor que deseja depositar: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    cEmpresa.Deposito(valor);
                }
                else if (resposta2 == 3)
                {
                    Console.WriteLine("Digite o valor que deseja pegar emprestado: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    cEmpresa.FazerEmprestimo(valor);
                }
            }
            else if (resposta1 == 2)
            {
                ContaEstudante cEstudante = new ContaEstudante("1234", "002", "Antonio", 78, 100, "111.222.333-44", "Ifro - Campus Jaru");

                Console.WriteLine("Escolha uma opção: " + "\n1- Saque \n2- Depósito");
                int resposta3 = Convert.ToInt32(Console.ReadLine());

                if (resposta3 == 1)
                {
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    cEstudante.Sacar(valor);
                }
                else if (resposta3 == 2)
                {
                    Console.WriteLine("Digite o valor que deseja depositar: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    cEstudante.Deposito(valor);
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        

        
	}

}
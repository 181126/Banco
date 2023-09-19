namespace Banco.Classes
{
    internal class ContaEmpresarial: Conta
    {
        public double Anuidade { get; set; }    
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial(string numeroConta, string agencia, string titularConta, double saldo,
            double limiteEmprestimo, double anuidade, double totalEmprestimo) : 
            base (numeroConta, agencia, titularConta, saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo; 
        }

        public void FazerEmprestimo(double valorEmprestimo) 
        {
            if (valorEmprestimo <= LimiteEmprestimo)
            {
                Saldo += valorEmprestimo;
                TotalEmprestimo += valorEmprestimo;
                Console.WriteLine("Empréstimo realizado com sucesso!Saldo da conta: " + Saldo);
            }
            else
            {
                Console.WriteLine("Empréstimo não concedido. Limite insuficiente!");
            }
        }

        public override void Sacar (double valor) 
        {
            if (valor >= 5000)
            {
                base.Sacar(valor + 5);
            }
            else if (valor >0 && valor < 5000)
            {
                base.Sacar (valor);
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}

namespace Banco.Classes
{
    internal class ContaEmpresarial: Conta
    {
        public double anuidade { get; set; }    
        public double limiteEmprestimo { get; set; }
        public double totalEmprestimo { get; set; }

        public ContaEmpresarial(string numeroConta, string agencia, string titularConta, double saldo,
            double limiteEmprestimo, double anuidade, double totalEmprestimo)
        {
            this.numeroConta = numeroConta;
            this.agencia = agencia;
            this.titularConta = titularConta;
            this.saldo = saldo;
            this.anuidade = anuidade;
            this.limiteEmprestimo = limiteEmprestimo;
            this.totalEmprestimo = totalEmprestimo; 
        }

        public void FazerEmprestimo(double valorEmprestimo) 
        {
            if (valorEmprestimo <= limiteEmprestimo)
            {
                saldo += valorEmprestimo;
                totalEmprestimo += valorEmprestimo;
                Console.WriteLine("Empréstimo realizado com sucesso!Saldo da conta: " + saldo);
            }
            else
            {
                Console.WriteLine("Empréstimo não concedido. Limite insuficiente!");
            }
        }

        public override void Sacar (double valor) 
        {
            base.Sacar (valor);

            if (valor >= 5000)
            {
                saldo -= 5; 
            }
            else
            {
                saldo = saldo; 
            }
        }
    }
}

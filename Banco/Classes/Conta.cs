namespace Banco.Classes
{
    internal class Conta
    {
        public string NumeroConta { get; set; } 
        public string Agencia { get; set; } 
        public string TitularConta { get; set; }    
        public double Saldo { get; set; }

        public Conta ()
        {

        }

        public Conta(string numeroConta, string agencia, string titularConta, double saldo)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            TitularConta = titularConta;
            Saldo = saldo;
        }

        public virtual void Sacar (double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Seu saldo agora é de: " + Saldo + " reais!");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Operação inválida");
            }
        }
        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine("Seu saldo agora é de: " + Saldo + " reais!");
            }
            else 
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}

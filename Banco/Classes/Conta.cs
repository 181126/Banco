namespace Banco.Classes
{
    internal class Conta
    {
        public string numeroConta { get; set; } 
        public string agencia { get; set; } 
        public string titularConta { get; set; }    
        public double saldo { get; set; }

        public virtual void Sacar (double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Seu saldo agora é de: " + saldo + " reais!");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }
        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Seu saldo agora é de: " + saldo + " reais!");
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}

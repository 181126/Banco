namespace Banco.Classes
{
    internal class ContaEstudante: Conta
    {
        public double LimiteChequeEspecial { get; set; }   
        public string Cpf { get; set; } 
        public string NomeInstituicao { get; set; }      
        
        public ContaEstudante (double limiteChequeEspecial, string cpf, string nomeInstituicao,
        string numeroConta, string agencia, string titularConta, double saldo) : base (numeroConta, agencia, titularConta, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao; 
        }
        public override void Sacar (double valor)
        {
            if (valor <= LimiteChequeEspecial + Saldo && valor > 0)
            {
                Saldo -= valor;
                Console.WriteLine("Saldo atual: " + Saldo);
            }
            else 
            {
                Console.WriteLine("Valor inválido!");
            }
            
        }
    }
}

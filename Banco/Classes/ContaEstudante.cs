namespace Banco.Classes
{
    internal class ContaEstudante: Conta
    {
        public double limiteChequeEspecial { get; set; }   
        public string cpf { get; set; } 
        public string nomeInstituicao { get; set; }     

        public ContaEstudante (string numeroConta, string agencia, string titularConta, double saldo, 
            double limiteChequeEspecial, string cpf, string nomeInstituicao) 
        {
            this.numeroConta = numeroConta;
            this.agencia = agencia;
            this.titularConta = titularConta;
            this.saldo = saldo;
            this.limiteChequeEspecial = limiteChequeEspecial;
            this.cpf = cpf;
            this.nomeInstituicao = nomeInstituicao;
        }
        public override void Sacar (double valor)
        {
            if (valor <= (limiteChequeEspecial + saldo))
            {
                saldo -= valor;
                Console.WriteLine("Saldo atual: " + saldo);
            }
            else
            {
                base.Sacar(valor);
            }
            
        }
    }
}

namespace Conta.C
{
    public class Corrente
    {
        //Atributos da nossa classe Pessoa
        public string titular { get; set; }
        public decimal saldo { get; set; } = 0;


        //Método construtor da classe Pessoa

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo é {saldo}");
        }


        public void DepositarSaldo()
        {
            int valor = int.Parse(Console.ReadLine());
            saldo += valor;
            Console.WriteLine("Deposito efetuado");

        }
        public void SacarSaldo()
        {
            int valor = int.Parse(Console.ReadLine());
            saldo -= valor;
            Console.WriteLine("Deposito efetuado");

        }

    }

}



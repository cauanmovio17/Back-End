using Conta.C;

public class Program
{

    public static string[] bank;

    public static void Main()
    {
        Corrente conta1 = new Corrente();

        Console.Clear();
        Console.WriteLine("Bem-vindo a sua conta");
        Console.WriteLine("---------------------");
        Console.WriteLine("Aqui você tem seu dinheiro rendendo");
        Console.WriteLine("");
        Console.WriteLine("Digite o nome do titular para acessar a conta");
        conta1.titular = Console.ReadLine();
        Console.WriteLine("");

        string opcao = "";

        do
        {
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Para Consultar o saldo");
            Console.WriteLine("2 - Para depositar");
            Console.WriteLine("3 - Para sacar");
            Console.WriteLine("0 - Para sair");
            opcao = Console.ReadLine();
            Console.Clear();


            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    conta1.ConsultarSaldo();
                    break;
                case "2":
                    conta1.DepositarSaldo();
                    break;
                case "3":
                    conta1.SacarSaldo();
                    break;
                default:

                    Console.WriteLine("Opção invalida");

                    break;
            }





        } while (opcao != "0");



    }
}


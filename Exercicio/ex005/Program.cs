class Program
{
    static void Main(string[] args)
    { ListaDoChurrasco(); SonhosDeConsumo(); }
    static void ListaDoChurrasco()
    {
        string[] produtos = new string[6]; for (int i = 0; i < 6; i++)
        { Console.Write($"Digite o produto {i + 1}: "); produtos[i] = Console.ReadLine(); }
        Array.Sort(produtos); Console.WriteLine("\nLista do Churrasco em ordem alfabética:"); foreach (string produto in produtos)
        { Console.WriteLine(produto); }
    }
    static void SonhosDeConsumo()
    {
        string[] sonhos = new string[3]; double[] valores = new double[3]; for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o sonho {i + 1}: "); sonhos[i] = Console.ReadLine(); Console.Write($"Digite o valor estimado para conquistar o sonho {i + 1}: "); if (double.TryParse(Console.ReadLine(), out double valor))
            { valores[i] = valor; }
            else { Console.WriteLine("Valor inválido. Digite um número válido."); i--; }
        }

        double total = 0; foreach (double valor in valores) { total += valor; }
        Console.WriteLine($"\nPara realizar seus sonhos de consumo, você precisará de R${total:N2}.");
    }
}
class Program
{
    public static void Main()

    {
        Console.Clear();
        string Continuar = "y";
        while(Continuar == "y")
        {
            Console.Write("Digite um numero para taboada");
            int NumeroTaboada = int.Parse(Console.ReadLine());
            TaboadaWhile(NumeroTaboada); 


            Console.Write("Digite um numero para dobralo");
            float NumeroDobro = int.Parse(Console.ReadLine());
            Console.WriteLine(Dobro(NumeroDobro));

            Console.Write("Digite um numero para obter a metade");
            float NumeroMetade = float.Parse(Console.ReadLine());
            Console.WriteLine(Metade(NumeroMetade));

            Console.Write("Continuar ?");
            Continuar = Console.ReadLine();
        }
        Console.Clear();



    }

public static string Metade(float Num)
{
    return $"A metade de {Num} é {Num / 2}";
}
public static string Dobro(float Num)
{
    return $"O dobro de {Num} é {Num * 2}";
}

public static void TaboadaWhile(int Num)
{
  
  int contador = 0;
  while (contador < 10){
    
  contador++;

  Console.WriteLine($"{Num} x {contador} = {Num * contador}");

  }

  

}

public static void SomaWhile()
{
    float MENOR = 0;
    float MAIOR = 0;
    float SOMA = 0;
    do
    {
        Console.Write("Digite um numero positivo");
        int Num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (Num1 < 0)
        {
            break;
        }

        if (Num1 > MAIOR)

        {
            MAIOR = Num1;
        }else{
            MENOR = Num1;
        }
        Console.WriteLine($"{SOMA} + {Num1} = {SOMA + Num1}"); 
        SOMA = SOMA + Num1;
            Console.WriteLine("");

    }while (true);

    Console.WriteLine("");
    Console.WriteLine("Numero negativo encontrado, Desconectando");
    Console.WriteLine("");




}






}

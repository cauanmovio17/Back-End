//Função em JavaScript
//Function nomefuncao (nome){
//}

//Funcao / Método em C#
//public static string NomeFuncao(string nome) {
//}

class Sesi
{

    public static void Main()
    {
        MostrarMensagem("Sejá bem vindo");
        MostrarMensagem(" SESI / SENAI");
        ImprimirDataHora();
        //Chamado o metodo Potenciacao com o parametro 4 e recebendo o retorno
        double potencia = Potenciacao(4);
        Console.WriteLine($"Potenciação {Potenciacao}");

        ContagemRegressiva(10);
     

    }


   public static double Potenciacao(int num)
   {
  double resultado = Math.Pow(num, 2);
  return resultado;
   }
//Metodo sem parametro e sem retorno
   public static void ImprimirDataHora()
   {
    Console.WriteLine(DateTime.Now.ToString());
   }

//Metodo com parametro e sem retorno
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
            {
                Console.WriteLine(n);
                n--;
                System.Threading.Thread.Sleep(1000);

            }
            Console.WriteLine("BOOOOOM");
    }


    public static void JogoQueNrSouEu()
    {
   Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
   Console.WriteLine("           Bem vindo ao Jogo             ");
   Console.WriteLine("Sorteei um n° de 1 a 20, tente adivinha-lo");
   Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
   Console.WriteLine(""); //Linha em branco

   Random rnd = new Random();
   int nrSorteado = rnd.Next(20);
   int nrDigitando = -1;

   do {

Console.WriteLine("Digite um n°");
nrDigitando = int.Parse(Console.ReadLine());
if (nrDigitando > nrSorteado)
Console.WriteLine("O número digitado é MAIOR que o sorteado");
else if (nrDigitando < nrSorteado)
Console.WriteLine("O número digitado é MENOR que o sorteado");
 } while (nrDigitando != nrSorteado);

 Console.WriteLine("Parabéns você acertou");

    }
}
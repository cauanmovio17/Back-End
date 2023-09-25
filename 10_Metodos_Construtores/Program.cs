using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da Classe Pessoa
        //Instanciando sem um método construtor
        /* Pessoa pessoa1 = new Pessoa ();
         pessoa1.nome = "Cauan";
         pessoa1.idade = 16;
         pessoa1.Cantar();


         //Alternativa para criação de um objeto sem construtor
         Pessoa pessoa2 = new Pessoa {
             nome = "Messi",
             idade = 36
         };
         pessoa2.Cantar();
         */

        Pessoa pessoa1 = new Pessoa("Felipe", 17, "FelipePorto@gmail.com", 2005);
        pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("Cauan", 16, "Cauanmovio17@gmail.com", 2006);
        pessoa2.Cantar();
        pessoa2.Informacoes();


        Pessoa pessoa3 = new Pessoa("Julio", 16, "JulioPinto@gmail.com", 2007);
        pessoa3.Cantar();
        pessoa3.Informacoes();


    }
}
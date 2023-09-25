public class Program
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "Messi",
            idade = 36
        };
        var pessoa2 = new {
            nome = "Cristiano Ronaldo",
            idade = 38,
            email = "cris7@aluno.senai.br"
        };
        var carro1 = new {
            marca = "Ford",
            ano = 2020,
            modelo = "Ranger"
        };
        var carro2 = new {
            marca = "Fiat",
            ano = 2000,
            modelo = "Uno"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e tem {pessoa2.idade} anos");
        Console.WriteLine($"A marca é {carro1.marca} do ano {carro1.ano}, no modelo {carro1 .modelo}");
        Console.WriteLine($"A marca é {carro2.marca} do ano {carro2.ano}, no modelo {carro2.modelo}");

       // pessoa1.nome = "Lucas";

       //Criar 2 objetos de classe anonima de Carro
    }
}
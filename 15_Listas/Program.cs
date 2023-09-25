using System.Collections.Generic;

using Sesi.Models;

public class Program
{
    public static void Main()

    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();


        //Adicionando elementos á lista
        listaNumeros.Add(10); //Posição (0)
        listaNumeros.Add(20);  //Posição (1)
        listaNumeros.Add(45);  //Posição (2)

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[2]);


        //Contagem de elementos
        Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); //Posição (3)
        Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");




        List<string> listaNome = new List<string>();

        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        listaNome.Add("Cauan");
        listaNome.Add("Gabriel");
        listaNome.Add("Calleri");


        Console.WriteLine(listaNome[1]);

        foreach (string Messi in listaNome)
        {
            Console.WriteLine(Messi);
        }



        Console.WriteLine($" Neste momento temos {listaNome.Count} elementos");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");

        //Criando uma lista de números já atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elementos na lista números: {numeros.Count}");
        numeros.Remove(5); //Remover o elemento 5
        numeros.RemoveAt(1); //Remover o elemento no indice 1 
        numeros.RemoveRange(2, 2); //Remover 2 elementos a partir do indice 2

        //Substituindo informação do item da lista
        numeros[0] = 100;

        //Interando sobre todos os itens da lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //Criando uma lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno á minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));


        //Exibindo lista de alunos
        Console.WriteLine("Lista alunos:");

        foreach (Aluno cris in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {cris.nome} tem {cris.idade} anos");
        }

        //Criando uma nova lista, ordenar por nome
        //LINQ utilizando Sintaxe de consulta
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }


        //LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
                         .Where(novoAluno => novoAluno.idade == 17)
                         .OrderBy(novoAluno => novoAluno.nome);

        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }









    }
}
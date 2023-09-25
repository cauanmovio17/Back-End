//Sempre que formos utilizar bibliotecas ou classes ja criadas
//importamos ela com o using


using Sesi.Model;

class Program
{
    public static void Main()
    {
        //Criando uma variável e instanciando da classe Aluno
        //Ou seja, estamos criando nosso projeto
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Douglas";
        aluno1.idade = "35";
        aluno1.turma = "2° EM";

        //Chamando o método da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();



        var aluno2 = new Aluno();

        aluno2.nome = "Cauan Movio";
        aluno2.idade = "16";
        aluno2.turma = "2° EM";


        aluno2.Apresentar();


        var aluno3 = new Aluno();

        aluno3.nome = "Lionel Messi";
        aluno3.idade = "36";
        aluno3.turma = "3° EM";


        aluno3.Apresentar();
    }
}
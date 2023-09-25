public class Program
{

    public static void Main()
    {


        //O try serve para tratar um erro e não parar a execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrope
        //a execução do bloco e vai para o catch

        try

        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o n° {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O resultado é: {resultado}");

        }

        //Tratando execão de overflow (estouro de campo)
        catch (OverflowException)
        {
            Console.WriteLine("Este numero  inteiro é maior que o suportado");
        }



        //Tratando exeção de erro de formato
        catch (FormatException)
        {
            Console.WriteLine("Erro digite um numero inteiro");
        }
        //Catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
        //Com o tipo do erro, para melhor compreenção do usuario

        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        //O finally é um bloco executado independentemente se ocorrer erro ou não

        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}

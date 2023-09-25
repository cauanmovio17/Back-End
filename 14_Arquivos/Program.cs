using System.IO;

public class Program
{
    public static void Main()
    {
        GravarArquivo();

        //Chamando metodo LerArquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {

        string CaminhoArquivo = "Arquivo/arquivo.txt";



        try
        {

            //Verificar se o arquivo existe
            if (File.Exists(CaminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando 
                //a verificação do if é falsa ou seja o arquivo não existe 
                File.Create(CaminhoArquivo);
            }

            //Instanciando um objeto da classe StreamReader para ler o arquivo                                                                                                                                                                                                                                              
            using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
            {
                string linha;
                //Fazendo o while para ler linha por linha que contem no arquivo 
                while ((linha = arquivo.ReadLine()) != null)
                {
                    //Escrevendo no console o conteúdo da linha
                    Console.WriteLine(linha);
                }

            }
        }



        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
    public static void GravarArquivo()
    {
        try
        {

            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                Console.WriteLine("Digite um texto para salvar no arquivo");
                string periodo = (Console.ReadLine());
                arquivo.WriteLine(periodo);
            }

        }

        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }


}
namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        private int anoNascimento { get; set; }

//Método construtor da classe Pessoa
        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa, int anoNascimento)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }


        //Método da classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes()
        {
            Console.WriteLine($"{nome} tem o email {email}, nasceu em {anoNascimento} e tem {idade} anos");
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _18_CRUD_BD.Models
{

    [Table("Jogos")]
    public class Jogo
    {
        [Key] //Falando para o BD que este atributo será uma chave

        public int JogoId { get; set; }
        [Required(ErrorMessage="Nome é obrigatorio")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
        
    }
}
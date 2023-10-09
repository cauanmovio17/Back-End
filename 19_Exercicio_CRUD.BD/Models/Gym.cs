using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _19_Exercicio_CRUD.BD.Models
{

    [Table("Gyms")]
    public class Gym
    {
        [Key] 
        public int JogoId { get; set; }
        [Required(ErrorMessage="Nome é obrigatorio")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Patrocinio { get; set; }
        public string Campeonato { get; set; }
        public string Coach { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
        
    }
}
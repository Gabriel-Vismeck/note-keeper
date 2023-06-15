using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gerenciador_de_notas.Models
{
    [Table("Nota")]
    public class Nota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        [Display(Name = "Nota")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Column("Conteudo")]
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }
    }
}

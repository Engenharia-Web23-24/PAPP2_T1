using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PAPP2.Models
{
    public class UnidadeCurricular
    {
        [Key]
        [DisplayName("Código")]
        public string? Codigo { get; set; }

        [Required]
        public string? Nome { get; set; }

        public int ECTS { get; set; }

        [DisplayName("Inscrições")]
        public List<Inscricao> Inscricoes { get; set; }
    }
}

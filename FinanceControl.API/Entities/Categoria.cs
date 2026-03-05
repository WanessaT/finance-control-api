using FinanceControl.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.API.Entities
{
    public class Categoria : EntidadeBase
    {
        [Required]
        [StringLength(80)]
        public string nome { get; set; }
        public TipoTransacao tipoTransacao { get; set; }
        public int? usuarioId { get; set; }
        [ForeignKey("usuarioId")]
        public Usuario? usuario { get; set; }
    }
}

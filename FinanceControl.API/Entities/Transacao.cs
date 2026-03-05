using FinanceControl.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.API.Entities
{
    public class Transacao : EntidadeBase
    {
        [Required]
        [StringLength(100)]
        public string titulo { get; set; }
        [Required]
        [MaxLength(255)]
        public string descricao { get; set; }
        public string quantia { get; set; }
        public TipoTransacao tipoTransacao { get; set; }
        public int? categoriaId { get; set; }
        [ForeignKey("categoriaId")]
        public Categoria categoria { get; set; }
        public int? usuarioId { get; set; }
        [ForeignKey("usuarioId")]
        public Usuario usuario { get; set; }
        public DateTime data { get; set; }
    }
}

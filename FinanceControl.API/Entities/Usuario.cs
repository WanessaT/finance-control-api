using System.ComponentModel.DataAnnotations;

namespace FinanceControl.API.Entities
{
    public class Usuario : EntidadeBase
    {
        [Required]
        [StringLength(80)]
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}

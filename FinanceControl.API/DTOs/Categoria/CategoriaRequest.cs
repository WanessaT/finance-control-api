using FinanceControl.API.Enums;

namespace FinanceControl.API.DTOs.Categoria
{
    public class CategoriaRequest : DTOBase
    {
        public string nome { get; set; }
        public TipoTransacao tipoTransacao { get; set; }
        public int? usuarioId { get; set; }
    }
}

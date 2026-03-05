using FinanceControl.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.API.DTOs.Transacao
{
    public class TransacaoResponse : DTOBase
    {
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string quantia { get; set; }
        public TipoTransacao tipoTransacao { get; set; }
        public int? categoriaId { get; set; }
        public int? usuarioId { get; set; }
        public DateTime data { get; set; }
    }
}

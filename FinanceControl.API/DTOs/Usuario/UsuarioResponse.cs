namespace FinanceControl.API.DTOs.Usuario
{
    public class UsuarioResponse : DTOBase
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}

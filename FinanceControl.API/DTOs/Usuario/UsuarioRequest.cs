namespace FinanceControl.API.DTOs.Usuario
{
    public class UsuarioRequest : DTOBase
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}

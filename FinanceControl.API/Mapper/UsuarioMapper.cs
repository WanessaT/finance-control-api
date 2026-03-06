using FinanceControl.API.DTOs.Usuario;
using FinanceControl.API.Entities;

namespace FinanceControl.API.Mapper
{
    public class UsuarioMapper
    {
        public static Usuario ToEntity(UsuarioRequest usuarioDTO)
        {
            return new Usuario
            {
                nome = usuarioDTO.nome,
                email = usuarioDTO.email,
                senha = usuarioDTO.senha,
                criadoEm = DateTime.UtcNow,
                editadoEm = DateTime.UtcNow,
            };
        }
        public static UsuarioResponse ToResponse(Usuario usuario)
        {
            return new UsuarioResponse
            {
                id = usuario.id,
                nome = usuario.nome,
                email = usuario.email,
                criadoEm = usuario.criadoEm,
                editadoEm = usuario.editadoEm
            };
        }

    }
}

using FinanceControl.API.DTOs.Usuario;
using FinanceControl.API.Entities;

namespace FinanceControl.API.Mapper
{
    public class UsuarioMapper
    {
        public static Usuario ConvertToEntity(UsuarioRequest usuarioDTO)
        {
            return new Usuario
            {
                id = usuarioDTO.id,
                nome = usuarioDTO.nome,
                email = usuarioDTO.email,
                senha = usuarioDTO.senha
            };
        }
        public static UsuarioResponse ConvertToResponse(Usuario usuario)
        {
            return new UsuarioResponse
            {
                id = usuario.id,
                nome = usuario.nome,
                email = usuario.email
            };
        }

        public static UsuarioListResponse ConvertToListResponse(Usuario usuario)
        {
            return new UsuarioListResponse
            {
                id = usuario.id,
                nome = usuario.nome,
                email = usuario.email
            };
        }


    }
}

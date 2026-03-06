
using FinanceControl.API.Data;
using FinanceControl.API.DTOs.Usuario;
using FinanceControl.API.Entities;
using FinanceControl.API.Mapper;
using FinanceControl.API.Repositories;

namespace FinanceControl.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositories _usuarioRepositories;
        private readonly DataContext _context;

        public UsuarioService(IUsuarioRepositories usuarioRepositories, DataContext context)
        {
            _usuarioRepositories = usuarioRepositories;
            _context = context;
        }

        public UsuarioResponse CriarUsuario(UsuarioRequest request)
        {
            var existeUsuario = _usuarioRepositories.GetByEmail(request.email).Any();

            if (existeUsuario)
            {
                throw new Exception("O email informado já está sendo usado por outro usuário.");
            }

            var senhaHash = BCrypt.Net.BCrypt.HashPassword(request.senha);
            request.senha = senhaHash;

            var usuario = UsuarioMapper.ToEntity(request);

            _usuarioRepositories.InsertUsuario(usuario);
            _context.SaveChanges();

            return UsuarioMapper.ToResponse(usuario);
        }

        public UsuarioResponse BuscarPorId(int id)
        {
            var usuarioEncontrado = _usuarioRepositories.GetById(id).FirstOrDefault();

            if (usuarioEncontrado == null)
            {
                throw new Exception("Usuário não encontrado.");
            }

            var usuarioResponse = UsuarioMapper.ToResponse(usuarioEncontrado);

            return usuarioResponse;
        }

    }
    public interface IUsuarioService
    {
        UsuarioResponse CriarUsuario(UsuarioRequest request);
        UsuarioResponse BuscarPorId(int id);
    }
}


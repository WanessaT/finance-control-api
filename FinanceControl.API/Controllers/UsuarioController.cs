using FinanceControl.API.DTOs.Usuario;
using FinanceControl.API.Entities;
using FinanceControl.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.API.Controllers
{
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("/Usuario/{id}")]
        public ActionResult<UsuarioResponse> ObterUsuarioPorId(int id)
        {
            return _usuarioService.BuscarPorId(id);
        }

        [HttpPost]
        public ActionResult<UsuarioResponse> CriarUsuario(UsuarioRequest request)
        {
            return _usuarioService.CriarUsuario(request);
        }
    }
}

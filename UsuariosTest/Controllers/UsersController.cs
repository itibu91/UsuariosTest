using UsuariosTest.Infrastructure;
using UsuariosTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace UsuariosTest.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Usuarios")]
    public class UsersController : ControllerBase
    {
        private readonly UsuarioDbContext _usuarioDbContext;
        private List<Usuario> usuarios;
        private readonly ILogger<UsersController> _logger;

        public UsersController(UsuarioDbContext usuarioDbContext, ILogger<UsersController> logger)
        {
            usuarios = new List<Usuario>();
            _usuarioDbContext = usuarioDbContext;
            _logger = logger;
        }


        // GET: api/usuarios?page=1&pageSize=10
        [HttpGet(Name = "ListarUsuarios")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios(int page = 1, int pageSize = 10)
        {
            var usuarios = await _usuarioDbContext.Usuarios
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(usuarios);
        }

        [HttpPost(Name = "AgregarUsuario")]
        public async Task<IActionResult> CrearUsuario([FromBody] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioDbContext.Usuarios.Add(usuario);
                await _usuarioDbContext.SaveChangesAsync();
                return Ok(usuario);
            }

            return BadRequest(ModelState);
        }

        [HttpGet("TotalUsuarios")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            var usuarios = await _usuarioDbContext.Usuarios.ToListAsync();

            return Ok(usuarios);
        }
    }
}

using AmigaoAPI.Application.DTO;
using AmigaoAPI.Application.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmigaoAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [HttpPost("create")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateAsync([FromBody] UsuarioDTO? usuarioDto)
        {
            if (usuarioDto == null)
            {
                return BadRequest("O objeto precisa ser enviado");
            }

            var result = await _usuarioService.CreateAsync(usuarioDto);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get-all")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _usuarioService.GetAllAsync();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _usuarioService.GetByIdAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update-usuario")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateAsync([FromBody] UsuarioDTO usuarioDto)
        {
            if (usuarioDto == null)
            {
                return BadRequest("O objeto precisa ser enviado");
            }

            var result = await _usuarioService.UpdateAsync(usuarioDto);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID inválido");
            }

            var result = await _usuarioService.DeleteAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

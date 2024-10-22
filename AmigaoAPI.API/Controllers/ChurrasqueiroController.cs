using AmigaoAPI.Application.DTO;
using AmigaoAPI.Application.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmigaoAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChurrasqueiroController : BaseController
    {
        private readonly IChurrasqueiroService _churrasqueiroService;
        private readonly IUsuarioService _usuarioService;

        public ChurrasqueiroController(IChurrasqueiroService churrasqueiroService, IUsuarioService usuarioService)
        {
            _churrasqueiroService = churrasqueiroService;
            _usuarioService = usuarioService;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> CreateAsync([FromBody] ChurrasqueiroDTO? churrasqueiroDto)
        {
            if (churrasqueiroDto == null)
            {
                return BadRequest("O objeto precisa ser enviado");
            }

            var result = await _churrasqueiroService.CreateAsync(churrasqueiroDto);
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
            var result = await _churrasqueiroService.GetAllAsync();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> ObterPorIdAsync(int id)
        {
            var result = await _churrasqueiroService.ObterPorIdAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update-churrasqueiro")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateAsync([FromBody] ChurrasqueiroDTO churrasqueiroDto)
        {
            if (churrasqueiroDto == null)
            {
                return BadRequest("O objeto precisa ser enviado");
            }

            var result = await _churrasqueiroService.UpdateAsync(churrasqueiroDto);
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

            var result = await _churrasqueiroService.DeleteAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

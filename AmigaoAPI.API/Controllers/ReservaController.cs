using AmigaoAPI.Application.DTO;
using AmigaoAPI.Application.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmigaoAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : BaseController
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpPost]
        [HttpPost("create")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateAsync([FromBody] ReservaDTO? reservaDto)
        {
            if (reservaDto == null)
            {
                return BadRequest("O objeto precisa ser enviado");
            }

            var result = await _reservaService.CreateAsync(reservaDto);
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
            var result = await _reservaService.GetAllAsync();
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
            var result = await _reservaService.GetByIdAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update-reserva")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateAsync([FromBody] ReservaDTO reservaDto)
        {
            if (reservaDto == null)
            {
                return BadRequest("O objeto precisa ser enviado");
            }

            var result = await _reservaService.UpdateAsync(reservaDto);
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

            var result = await _reservaService.DeleteAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

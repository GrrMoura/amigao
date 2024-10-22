using AmigaoAPI.Application.DTO;
using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Services;

namespace AmigaoAPI.Application.Services.Interface
{
    public interface IReservaService
    {
        Task<ResultService<Reserva>> CriarReservaAsync(Reserva reserva);
        Task<ResultService<bool>> CancelarReservaAsync(int id);
        Task<ResultService<List<Reserva>>> ListarReservasPendentesAsync();
        Task<ResultService<Reserva>> ConfirmarContratacaoAsync(int id);
        Task<ResultService<Reserva>> UpdateAsync(ReservaDTO reservaDto);
        Task<ResultService<Reserva>> DeleteAsync(int id);
        Task<ResultService<Reserva>> CreateAsync(ReservaDTO reservaDto);
        Task<ResultService<Reserva>> GetAllAsync();
        Task<ResultService<Reserva>> GetByIdAsync(int id);
    }
}

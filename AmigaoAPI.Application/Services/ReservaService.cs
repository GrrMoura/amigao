using AmigaoAPI.Application.DTO;
using AmigaoAPI.Application.Services.Interface;
using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Domain.Services;

namespace AmigaoAPI.Application.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepositorio _reservaRepositorio;

        public ReservaService(IReservaRepositorio reservaRepositorio)
        {
            _reservaRepositorio = reservaRepositorio;
        }

        public async Task<Reserva?> CreateReservaAsync(Reserva reserva)
        {
            return await _reservaRepositorio.CreateAsync(reserva);
        }

        public async Task<Reserva?> GetReservaByIdAsync(int? id)
        {
            return await _reservaRepositorio.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Reserva>> ListarReservasPendentesAsync(int churrasqueiroId)
        {
            return await _reservaRepositorio.ListarReservasPendentesAsync(churrasqueiroId);
        }

        Task<ResultService<bool>> IReservaService.CancelarReservaAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Reserva>> IReservaService.ConfirmarContratacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Reserva>> IReservaService.CreateAsync(ReservaDTO reservaDto)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Reserva>> IReservaService.CriarReservaAsync(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Reserva>> IReservaService.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Reserva>> IReservaService.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Reserva>> IReservaService.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<List<Reserva>>> IReservaService.ListarReservasPendentesAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Reserva>> IReservaService.UpdateAsync(ReservaDTO reservaDto)
        {
            throw new NotImplementedException();
        }
    }
}

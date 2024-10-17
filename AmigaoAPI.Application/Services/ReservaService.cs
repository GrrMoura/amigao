using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Application.Services
{
    public class ReservaService
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
    }
}

using AmigaoAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Application.Services.Interface
{
    public interface IReservaService
    {
        Task<Reserva> CriarReservaAsync(Reserva reserva);
        Task<bool> CancelarReservaAsync(int id);
        Task<List<Reserva>> ListarReservasPendentesAsync();
        Task<Reserva> ConfirmarContratacaoAsync(int id);
    }
}

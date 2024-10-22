using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AmigaoAPI.Infra.Data.Repositorios
{
    public class ReservaRepositorio : IReservaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public ReservaRepositorio(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Reserva?> CreateAsync(Reserva reserva)
        {
            await _db.Reservas.AddAsync(reserva);
            await _db.SaveChangesAsync();
            return reserva;
        }

        public async Task<IEnumerable<Reserva>> GetReservasPendentesAsync()
        {
            return await _db.Reservas
                .Where(r => r.Status == "Pendente")
                .ToListAsync();
        }

        public async Task<IEnumerable<Reserva>> GetReservasByClienteAsync(int clienteId)
        {
            return await _db.Reservas
                .Where(r => r.IdUsuario == clienteId)
                .ToListAsync();
        }

        public async Task ConfirmarReservaAsync(int id)
        {
            var reserva = await _db.Reservas.FindAsync(id);
            if (reserva != null)
            {
                reserva.Status = "Confirmada";
                await _db.SaveChangesAsync();
            }
        }

        public async Task<bool> CancelarReservaAsync(int id)
        {
            var reserva = await _db.Reservas.FindAsync(id);
            if (reserva != null)
            {
                reserva.Status = "Cancelada";
                await _db.SaveChangesAsync();
            }
            return true;
        }

        public async Task<Reserva?> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Reserva>> ListarReservasPendentesAsync(int churrasqueiroId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Reserva>> ListarReservasDoClienteAsync(int clienteId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ConfirmarContratacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RecusarContratacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> FinalizarContratacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Reserva>> ListarContratacoesEmAndamentoAsync(int clienteId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Reserva>> VerContratacoesDoClienteAsync(int clienteId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AvaliarContratacaoAsync(int id, decimal nota, string comentario)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Reserva>> VerContratacoesAnterioresAsync(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}

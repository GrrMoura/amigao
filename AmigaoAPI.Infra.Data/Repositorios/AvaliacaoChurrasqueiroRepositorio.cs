using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Infra.Data.Repositorios
{
    public class AvaliacaoChurrasqueiroRepositorio : IAvaliacaoChurrasqueiroRepositorio
    {
        private readonly ApplicationDbContext _db;

        public AvaliacaoChurrasqueiroRepositorio(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<AvaliacaoChurrasqueiro?> CreateReview(AvaliacaoChurrasqueiro avaliacaoChurrasqueiro)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteReview(int id)
        {
            throw new NotImplementedException();
        }

        public async Task EditReview(AvaliacaoChurrasqueiro avaliacaoChurrasqueiro)
        {
            throw new NotImplementedException();
        }

        public async Task<AvaliacaoChurrasqueiro> GetBookingReview(int id, int idReserva)
        {
            throw new NotImplementedException();
        }

        public async Task<AvaliacaoChurrasqueiro?> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<AvaliacaoChurrasqueiro> GetChurrasqueiroAverageRating(int idChurrasqueiro)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AvaliacaoChurrasqueiro>> GetChurrasqueiroReviews(int idChurrasqueiro)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AvaliacaoChurrasqueiro>> GetClientReviews(int idCliente)
        {
            throw new NotImplementedException();
        }

        public async Task GetReview(int id)
        {
            throw new NotImplementedException();
        }
    }
}

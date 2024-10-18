using AmigaoAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Repositorios
{
    public interface IAvaliacaoChurrasqueiroRepositorio
    {
        Task<AvaliacaoChurrasqueiro?> CreateReview(AvaliacaoChurrasqueiro avaliacaoChurrasqueiro);
        Task<AvaliacaoChurrasqueiro?> GetByIdAsync(int? id);
        Task EditReview(AvaliacaoChurrasqueiro avaliacaoChurrasqueiro); // Atualizar a avaliação do churrasqueiro
        Task DeleteReview(int id); // Deletar uma avaliação
        Task<IEnumerable<AvaliacaoChurrasqueiro>> GetChurrasqueiroReviews(int idChurrasqueiro); // Lista as avaliações de um determinado churrasqueiro
        Task<AvaliacaoChurrasqueiro> GetBookingReview(int id, int idReserva); // Lista a avaliação de uma reserva específica
        Task<IEnumerable<AvaliacaoChurrasqueiro>> GetClientReviews(int idCliente); // Lista todas as avaliações feitas por um cliente em seus churrasqueiros contratados
        Task<AvaliacaoChurrasqueiro> GetChurrasqueiroAverageRating(int idChurrasqueiro); // Lista a media de todas as avaliações feitas em um churrasqueiro
        Task GetReview(int id); // Retorna uma avaliação específica
    }
}

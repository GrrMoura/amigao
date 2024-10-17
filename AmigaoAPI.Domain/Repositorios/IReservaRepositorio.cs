using AmigaoAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Repositorios
{
    public interface IReservaRepositorio
    {
        Task<Reserva?> CreateAsync(Reserva reserva); // Criar nova reserva
        Task<Reserva?> GetByIdAsync(int? id); // Obter reserva por ID
        Task<bool> CancelarReservaAsync(int id); // Cancelar reserva
        Task<IEnumerable<Reserva>> ListarReservasPendentesAsync(int churrasqueiroId); // Listar reservas pendentes
        Task<IEnumerable<Reserva>> ListarReservasDoClienteAsync(int clienteId); // Listar reservas do cliente
        Task<bool> ConfirmarContratacaoAsync(int id); // Confirmar contratação
        Task<bool> RecusarContratacaoAsync(int id); // Recusar contratação
        Task<bool> FinalizarContratacaoAsync(int id); // Finalizar contratação
        Task<IEnumerable<Reserva>> ListarContratacoesEmAndamentoAsync(int clienteId); // Listar contratações em andamento
        Task<IEnumerable<Reserva>> VerContratacoesDoClienteAsync(int clienteId); // Ver contratações do cliente
        Task<bool> AvaliarContratacaoAsync(int id, decimal nota, string comentario); // Avaliar contratação
        Task<IEnumerable<Reserva>> VerContratacoesAnterioresAsync(int clienteId); // Ver contratações anteriores
    }
}

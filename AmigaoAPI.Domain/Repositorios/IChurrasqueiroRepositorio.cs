using AmigaoAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Repositorios
{
    public interface IChurrasqueiroRepositorio
    {
        Task<Churrasqueiro?> CreateAsync(Churrasqueiro churrasqueiro);
        Task<Churrasqueiro?> GetByIdAsync(int? id);

        // Métodos adicionais para gerenciamento de churrasqueiros
        Task UpdateAsync(Churrasqueiro churrasqueiro); // Atualizar informações do churrasqueiro
        Task DeleteAsync(int id); // Deletar um churrasqueiro
        Task<IEnumerable<Churrasqueiro>> ListarChurrasqueirosDisponiveisAsync(); // Listar churrasqueiros disponíveis
        Task<bool> AtualizarPrecoPorHoraAsync(int id, decimal novoPreco); // Atualizar preço por hora
        Task<bool> AtualizarDisponibilidadeAsync(int id, bool disponibilidade); // Atualizar disponibilidade
        Task<IEnumerable<Usuario>> VisualizarAvaliacoesAsync(int id); // Visualizar avaliações (substituído por Usuário)
        Task<IEnumerable<Reserva>> VerContratacoesPendentesAsync(int id); // Ver contratações pendentes (substituído por Reserva)
        Task<bool> AceitarContratacaoAsync(int id); // Aceitar uma contratação
        Task<bool> RecusarContratacaoAsync(int id); // Recusar uma contratação
        Task<IEnumerable<Reserva>> VerHistoricoContratacoesAsync(int id); // Ver histórico de contratações (substituído por Reserva)
        Task<bool> AlterarStatusAtividadeAsync(int id, bool ativo); // Alterar status de atividade
        Task<bool> AtualizarPerfilAsync(Churrasqueiro churrasqueiro); // Atualizar perfil do churrasqueiro
        Task<bool> SolicitarPagamentoAsync(int id); // Solicitar pagamento
    }
}

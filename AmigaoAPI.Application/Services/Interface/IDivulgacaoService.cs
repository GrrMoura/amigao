using AmigaoAPI.Domain.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Servicos
{
    public interface IDivulgacaoService
    {
        Task CadastrarDivulgacaoAsync(Divulgacao divulgacao);        // Método para cadastrar uma nova divulgação
        Task<Divulgacao> ObterDivulgacaoPorIdAsync(int id);          // Método para obter uma divulgação por ID
        Task<IEnumerable<Divulgacao>> ObterTodasDivulgacoesAsync();  // Método para obter todas as divulgações
        Task AtualizarDivulgacaoAsync(Divulgacao divulgacao);        // Método para atualizar uma divulgação existente
        Task RemoverDivulgacaoAsync(int id);                         // Método para remover uma divulgação
    }
}


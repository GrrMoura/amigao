using AmigaoAPI.Application.DTO;
using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Services;

namespace AmigaoAPI.Application.Services.Interface
{
    public interface IChurrasqueiroService
    {
        Task<ResultService<Churrasqueiro>> CriarChurrasqueiroAsync(Churrasqueiro churrasqueiro);
        Task<ResultService<Churrasqueiro>> ObterPorIdAsync(int id);
        Task<ResultService<List<Churrasqueiro>>> ListarChurrasqueirosDisponiveisAsync();
        Task<ResultService<bool>> AtualizarPrecoPorHoraAsync(int id, decimal novoPreco);
        Task<ResultService<bool>> AtualizarDisponibilidadeAsync(int id, bool disponibilidade);
        Task<ResultService<Churrasqueiro>> CreateAsync(ChurrasqueiroDTO churrasqueiroDto);
        Task<ResultService<Churrasqueiro>> GetAllAsync();
        Task<ResultService<Churrasqueiro>> GetByIdAsync(int id);
        Task<ResultService<Churrasqueiro>> UpdateAsync(ChurrasqueiroDTO churrasqueiroDto);
        Task<ResultService<Churrasqueiro>> DeleteAsync(int id);
    }
}

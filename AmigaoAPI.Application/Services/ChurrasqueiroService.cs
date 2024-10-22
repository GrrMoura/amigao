using AmigaoAPI.Application.DTO;
using AmigaoAPI.Application.Services.Interface;
using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Domain.Services;

namespace AmigaoAPI.Application.Services
{
    public class ChurrasqueiroService : IChurrasqueiroService
    {
        private readonly IChurrasqueiroRepositorio _churrasqueiroRepositorio;

        public ChurrasqueiroService(IChurrasqueiroRepositorio churrasqueiroRepositorio)
        {
            _churrasqueiroRepositorio = churrasqueiroRepositorio;
        }

        public async Task<Churrasqueiro?> CreateChurrasqueiroAsync(Churrasqueiro churrasqueiro)
        {
            return await _churrasqueiroRepositorio.CreateAsync(churrasqueiro);
        }

        public async Task<Churrasqueiro?> GetChurrasqueiroByIdAsync(int? id)
        {
            return await _churrasqueiroRepositorio.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Churrasqueiro>> ListarChurrasqueirosDisponiveisAsync()
        {
            return await _churrasqueiroRepositorio.ListarChurrasqueirosDisponiveisAsync();
        }

        Task<ResultService<bool>> IChurrasqueiroService.AtualizarDisponibilidadeAsync(int id, bool disponibilidade)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<bool>> IChurrasqueiroService.AtualizarPrecoPorHoraAsync(int id, decimal novoPreco)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Churrasqueiro>> IChurrasqueiroService.CreateAsync(ChurrasqueiroDTO churrasqueiroDto)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Churrasqueiro>> IChurrasqueiroService.CriarChurrasqueiroAsync(Churrasqueiro churrasqueiro)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Churrasqueiro>> IChurrasqueiroService.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Churrasqueiro>> IChurrasqueiroService.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Churrasqueiro>> IChurrasqueiroService.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<List<Churrasqueiro>>> IChurrasqueiroService.ListarChurrasqueirosDisponiveisAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Churrasqueiro>> IChurrasqueiroService.ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Churrasqueiro>> IChurrasqueiroService.UpdateAsync(ChurrasqueiroDTO churrasqueiroDto)
        {
            throw new NotImplementedException();
        }
    }
}

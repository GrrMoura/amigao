using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Application.Services
{
    public class ChurrasqueiroService
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
    }
}

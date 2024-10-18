using AmigaoAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Application.Services.Interface
{
    public interface IChurrasqueiroService
    {
        Task<Churrasqueiro> CriarChurrasqueiroAsync(Churrasqueiro churrasqueiro);
        Task<Churrasqueiro> ObterPorIdAsync(int id);
        Task<List<Churrasqueiro>> ListarChurrasqueirosDisponiveisAsync();
        Task<bool> AtualizarPrecoPorHoraAsync(int id, decimal novoPreco);
        Task<bool> AtualizarDisponibilidadeAsync(int id, bool disponibilidade);
    }
}

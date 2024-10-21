using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using AmigaoAPI.Infra.Data.Context;

namespace AmigaoAPI.Domain.Repositorios
{
    public class DivulgacaoRepositorio : IDivulgacaoRepositorio
    {
        private readonly ApplicationDbContext _context;

        public DivulgacaoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CadastrarDivulgacaoAsync(Divulgacao divulgacao)
        {
            _context.Divulgacoes.Add(divulgacao);
            await _context.SaveChangesAsync();
        }

        public async Task<Divulgacao> ObterPorIdAsync(int id)
        {
            return await _context.Divulgacoes.FindAsync(id);
        }

        public async Task<IEnumerable<Divulgacao>> ObterTodasAsync()
        {
            return await _context.Divulgacoes.ToListAsync();
        }

        public async Task AtualizarDivulgacaoAsync(Divulgacao divulgacao)
        {
            _context.Divulgacoes.Update(divulgacao);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverDivulgacaoAsync(int id)
        {
            var divulgacao = await ObterPorIdAsync(id);
            if (divulgacao != null)
            {
                _context.Divulgacoes.Remove(divulgacao);
                await _context.SaveChangesAsync();
            }
        }
    }
}


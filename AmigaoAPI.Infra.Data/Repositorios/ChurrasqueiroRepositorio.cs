using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Infra.Data.Repositorios
{
    public class ChurrasqueiroRepositorio : IChurrasqueiroRepositorio // herdando a interface
    {
        private readonly ApplicationDbContext _db;  // criando a variável para o vinculo com o banco de dados 

        public ChurrasqueiroRepositorio(ApplicationDbContext db)
        {
            _db = db;  // fazendo a injeção de dependência...
                       // injeção de dependÊncia é como se eu tivesse pegando
                       // tudo oq tem (metodos, variaveis etc) dentro do AppplicationDBContext db e colocasse dentro do _db para
                       // facilicar o código
        }

        public async Task<Churrasqueiro?> CreateAsync(Churrasqueiro churrasqueiro)
        {
            await _db.AddAsync(churrasqueiro);
            await _db.SaveChangesAsync();
            return churrasqueiro;
        }

        public async Task<Churrasqueiro?> GetByIdAsync(int? id)
        {
            var churrasqueiro = await _db.Churrasqueiros.FindAsync(id); // aqui por exemplo..  o _db que foi injetado com as dependencias está acessando uma
                                                                        // classe chamada "Churrasqueiro" que está denttro do ApplicationDbContext
                                                                        // e que por está dentro do Aplication ela tem outros metodos, como adicionar, remover etc
            return churrasqueiro;
        }
        // Listar todos os churrasqueiros
        public async Task<IEnumerable<Churrasqueiro>> GetAllAsync()
        {
            return await _db.Churrasqueiros.ToListAsync();
        }



        public async Task DeleteAsync(int id)
        {
            var churrasqueiro = await GetByIdAsync(id);
            if (churrasqueiro != null)
            {
                _db.Churrasqueiros.Remove(churrasqueiro);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Churrasqueiro>> GetChurrasqueirosDisponiveis()
        {
            return await _db.Churrasqueiros
                .Where(c => c.Disponibilidade == true)
                .ToListAsync();
        }

        public async Task UpdateAsync(Churrasqueiro churrasqueiro)
        {
            _db.Churrasqueiros.Update(churrasqueiro);
            await _db.SaveChangesAsync();

        }


        Task IChurrasqueiroRepositorio.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Churrasqueiro>> IChurrasqueiroRepositorio.ListarChurrasqueirosDisponiveisAsync()
        {
            throw new NotImplementedException();
        }

        Task<bool> IChurrasqueiroRepositorio.AtualizarPrecoPorHoraAsync(int id, decimal novoPreco)
        {
            throw new NotImplementedException();
        }

        Task<bool> IChurrasqueiroRepositorio.AtualizarDisponibilidadeAsync(int id, bool disponibilidade)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Usuario>> IChurrasqueiroRepositorio.VisualizarAvaliacoesAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Reserva>> IChurrasqueiroRepositorio.VerContratacoesPendentesAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IChurrasqueiroRepositorio.AceitarContratacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IChurrasqueiroRepositorio.RecusarContratacaoAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Reserva>> IChurrasqueiroRepositorio.VerHistoricoContratacoesAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IChurrasqueiroRepositorio.AlterarStatusAtividadeAsync(int id, bool ativo)
        {
            throw new NotImplementedException();
        }

        Task<bool> IChurrasqueiroRepositorio.AtualizarPerfilAsync(Churrasqueiro churrasqueiro)
        {
            throw new NotImplementedException();
        }

        Task<bool> IChurrasqueiroRepositorio.SolicitarPagamentoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

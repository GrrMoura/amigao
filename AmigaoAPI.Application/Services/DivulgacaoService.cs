using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Servicos
{
    public class DivulgacaoService
    {
        private readonly IDivulgacaoRepositorio _divulgacaoRepositorio;

        public DivulgacaoService(IDivulgacaoRepositorio divulgacaoRepositorio)
        {
            _divulgacaoRepositorio = divulgacaoRepositorio;
        }

        public async Task CadastrarDivulgacao(Divulgacao divulgacao)
        {
            // Aqui você pode adicionar validações antes de salvar a divulgação.
            await _divulgacaoRepositorio.CadastrarDivulgacaoAsync(divulgacao);
        }
    }
}


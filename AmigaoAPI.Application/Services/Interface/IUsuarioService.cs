using AmigaoAPI.Application.DTO;
using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Services;

namespace AmigaoAPI.Application.Services.Interface
{
    public interface IUsuarioService
    {
        Task<ResultService<Usuario>> CriarUsuarioAsync(Usuario usuario);
        Task<ResultService<Usuario>> AutenticarAsync(string email, string senha);
        Task<ResultService<Usuario>> AtualizarPerfilAsync(Usuario usuario);
        Task<ResultService<bool>> VerificarDisponibilidadeEmailAsync(string email);

        Task<ResultService<UsuarioDTO>> CreateAsync(UsuarioDTO tituloDTO);
        Task<ResultService<ICollection<UsuarioDTO>>> GetAllAsync();
        Task<ResultService<Usuario>> GetByIdAsync(int id);
        Task<ResultService> UpdateAsync(UsuarioDTO tituloDTO);
        Task<ResultService> DeleteAsync(int id);
    }
}


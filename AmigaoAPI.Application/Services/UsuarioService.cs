using AmigaoAPI.Application.DTO;
using AmigaoAPI.Application.Services.Interface;
using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using AmigaoAPI.Domain.Services;

namespace AmigaoAPI.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<Usuario?> CreateUsuarioAsync(Usuario usuario)
        {
            return await _usuarioRepositorio.CreateAsync(usuario);
        }

        public async Task<Usuario?> GetUsuarioByIdAsync(int? id)
        {
            return await _usuarioRepositorio.GetByIdAsync(id);
        }

        public async Task<bool> AutenticarAsync(string email, string senha)
        {
            return await _usuarioRepositorio.AutenticarAsync(email, senha);
        }

        Task<ResultService<Usuario>> IUsuarioService.CriarUsuarioAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Usuario>> IUsuarioService.AutenticarAsync(string email, string senha)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Usuario>> IUsuarioService.AtualizarPerfilAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<bool>> IUsuarioService.VerificarDisponibilidadeEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<UsuarioDTO>> IUsuarioService.CreateAsync(UsuarioDTO tituloDTO)
        {
            throw new NotImplementedException();
        }

        Task<ResultService<ICollection<UsuarioDTO>>> IUsuarioService.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResultService<Usuario>> IUsuarioService.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResultService> IUsuarioService.UpdateAsync(UsuarioDTO tituloDTO)
        {
            throw new NotImplementedException();
        }

        Task<ResultService> IUsuarioService.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

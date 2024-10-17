using AmigaoAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Application.Services.Interface
{
    public interface IUsuarioService
    {
        Task<Usuario> CriarUsuarioAsync(Usuario usuario);
        Task<Usuario> AutenticarAsync(string email, string senha);
        Task<Usuario> AtualizarPerfilAsync(Usuario usuario);
        Task<bool> VerificarDisponibilidadeEmailAsync(string email);
    }
}

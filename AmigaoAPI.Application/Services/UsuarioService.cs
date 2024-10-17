using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Application.Services
{
    public class UsuarioService
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
    }
}

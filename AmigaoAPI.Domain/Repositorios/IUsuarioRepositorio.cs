using AmigaoAPI.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario?> CreateAsync(Usuario usuario); // Criar novo usuário
        Task<Usuario?> GetByIdAsync(int? id); // Obter usuário por ID
        Task<Usuario?> GetByEmailAsync(string email); // Obter usuário por e-mail
        Task<bool> AutenticarAsync(string email, string senha); // Autenticar usuário
        Task<bool> AtualizarSenhaAsync(int id, string novaSenha); // Atualizar senha
        Task<bool> RecuperarSenhaAsync(string email); // Recuperar senha
        Task<bool> AtualizarPerfilAsync(Usuario usuario); // Atualizar perfil
        Task<bool> AlterarTipoUsuarioAsync(int id, bool isChurrasqueiro); // Alterar tipo de usuário
        Task<bool> VerificarDisponibilidadeEmailAsync(string email); // Verificar disponibilidade de e-mail
        Task<IEnumerable<Usuario>> ListarUsuariosAsync(); // Listar usuários
    }
}

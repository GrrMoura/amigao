using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }  // Chave primária
        public string Nome { get; set; } = string.Empty;  // Nome do usuário
        public string Email { get; set; } = string.Empty;  // Email do usuário (único)
        public string PasswordHash { get; set; } = string.Empty;  // Senha criptografada
        public string TipoUsuario { get; set; } = string.Empty;  // Cliente ou Churrasqueiro

        public string? Endereco { get; set; }  // Endereço opcional
        public string? Telefone { get; set; }  // Telefone opcional

        public List<Reserva>? Reservas { get; set; }  // Relacionamento com Reservas

        // Métodos auxiliares para verificação de tipo de usuário
        public bool IsCliente() => TipoUsuario == "Cliente";
        public bool IsChurrasqueiro() => TipoUsuario == "Churrasqueiro";
    }
}

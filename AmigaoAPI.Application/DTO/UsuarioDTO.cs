using System.Collections.Generic;

namespace AmigaoAPI.Application.DTO
{
    public class UsuarioDTO
    {
        public int? Id { get; set; }  // Chave primária
        public string? Nome { get; set; } = string.Empty;  // Nome do usuário
        public string? Email { get; set; } = string.Empty;  // Email do usuário (único)
        public string? PasswordHash { get; set; } = string.Empty;  // Senha criptografada
        public string? TipoUsuario { get; set; } = string.Empty;  // Cliente ou Churrasqueiro

        public string? Endereco { get; set; }  // Endereço opcional
        public string? Telefone { get; set; }  // Telefone opcional

        // Atributos adicionais
        public bool? IsCliente { get; set; }  // Verifica se é cliente
        public bool? IsChurrasqueiro { get; set; }  // Verifica se é churrasqueiro

        // Relacionamento com as reservas
        public List<ReservaDTO> Reservas { get; set; } = new List<ReservaDTO>();  // Lista de reservas associadas
    }
}

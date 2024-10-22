using System;

namespace AmigaoAPI.Application.DTO
{
    public class ReservaDTO
    {
        public int Id { get; set; }  // Chave primária da reserva
        public int IdUsuario { get; set; }  // Chave estrangeira para o cliente (usuário)
        public int IdChurrasqueiro { get; set; }  // Chave estrangeira para o churrasqueiro
        public DateTime DataReserva { get; set; }  // Data e hora da reserva
        public string Status { get; set; } = string.Empty;  // Status da reserva (Pendente, Confirmada, Cancelada)

        // Atributos de avaliação
        public decimal Nota { get; set; }  // Nota dada pelo cliente para o churrasqueiro
        public string Comentario { get; set; } = string.Empty;  // Comentário do cliente sobre o serviço
    }
}

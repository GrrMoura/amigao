using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Modelos
{
    public class Reserva
    {
        public int Id { get; set; }  // Chave primária da reserva
        public int IdChurrasqueiro { get; set; }  // Chave estrangeira para o churrasqueiro
        public int IdUsuario { get; set; }  // Chave estrangeira para o cliente (usuário)

        public DateTime DataReserva { get; set; }  // Data da reserva
        public decimal ValorTotal { get; set; }  // Valor total da contratação
        public string Status { get; set; } = "Pendente";  // Status da reserva (Pendente, Confirmada, Cancelada, etc.)

        public Churrasqueiro? Churrasqueiro { get; set; }  // Navegação para Churrasqueiro
        public Usuario? Usuario { get; set; }  // Navegação para Cliente (Usuario)

        // Alterar status da reserva
        public void AlterarStatus(string novoStatus)
        {
            Status = novoStatus;
        }

        // Confirmar reserva
        public void Confirmar()
        {
            Status = "Confirmada";
        }

        // Cancelar reserva
        public void Cancelar()
        {
            Status = "Cancelada";
        }

        // Finalizar contratação
        public void Finalizar()
        {
            Status = "Finalizada";
        }
    }
}

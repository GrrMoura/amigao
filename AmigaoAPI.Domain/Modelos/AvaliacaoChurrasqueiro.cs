using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Modelos
{
    public class AvaliacaoChurrasqueiro
    {
        public int Id { get; set; }
        public int IdReserva { get; set; }
        public int IdChurrasqueiro { get; set; }
        public List<Churrasqueiro>? Churrasqueiro { get; set; }
        public int IdCliente { get; set; }
        public List<Cliente>? Cliente { get; set; }
        public double Nota { get; set; }
        public string? Comentario { get; set; }
        public DateTime DataAvaliacao { get; set; }
    }
}

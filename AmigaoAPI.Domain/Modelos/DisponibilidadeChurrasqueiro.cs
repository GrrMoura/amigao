using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Modelos
{
    public class DisponibilidadeChurrasqueiro
    {
        public int Id { get; set; }
        public int IdChurrasqueiro { get; set; }
        public DateTime DiaSemana { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Domain.Modelos
{
    public class Churrasqueiro : Usuario
    {
        public decimal PrecoPorHora { get; set; }  // Preço que o churrasqueiro cobra por hora
        public bool Disponibilidade { get; set; }  // Disponibilidade para novas reservas
        public double AvaliacaoMedia { get; set; }  // Avaliação média das contratações

        public List<Reserva>? Reserva { get; set; }  // Relacionamento com Reservas

        // Método para calcular a média das avaliações com base em uma lista de notas
        public void AtualizarAvaliacaoMedia(List<double> avaliacoes)
        {
            if (avaliacoes.Any())
            {
                AvaliacaoMedia = avaliacoes.Average();
            }
        }

        // Alterar disponibilidade do churrasqueiro
        public void AlterarDisponibilidade(bool disponivel)
        {
            Disponibilidade = disponivel;
        }

        // Atualizar preço por hora
        public void AtualizarPrecoPorHora(decimal novoPreco)
        {
            PrecoPorHora = novoPreco;
        }
    }
}

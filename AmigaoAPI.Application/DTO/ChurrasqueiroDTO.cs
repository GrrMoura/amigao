namespace AmigaoAPI.Application.DTO
{
    public class ChurrasqueiroDTO
    {
        public int Id { get; set; }  // Chave primária do churrasqueiro
        public decimal PrecoPorHora { get; set; }  // Preço que o churrasqueiro cobra por hora
        public bool Disponibilidade { get; set; }  // Disponibilidade para novas reservas
        public double AvaliacaoMedia { get; set; }  // Avaliação média das contratações
    }
}

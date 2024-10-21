public class Divulgacao
{
    public int Id { get; set; }                     // Identificador único
    public string NomeEmpresa { get; set; }          // Nome da empresa
    public string Contato { get; set; }              // Informações de contato (e-mail, telefone)
    public string DescricaoProdutos { get; set; }    // Descrição dos produtos
    public string TipoProduto { get; set; }          // Tipo de produto (carne, equipamentos, etc.)
    public DateTime DataSolicitacao { get; set; }    // Data da solicitação de divulgação
    public string StatusDivulgacao { get; set; }     // Status da divulgação (pendente, aprovada, etc.)
    public string Observacoes { get; set; }          // Notas ou observações
}

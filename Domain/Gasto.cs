namespace ControleDeGastos.Domain;

public class Gasto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid IdUsuario { get; set; } = Guid.NewGuid();
    public string Descricao { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public DateTime Data { get; set; }
}

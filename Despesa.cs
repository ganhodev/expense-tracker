namespace ControleDeGastos;

public class Despesa
{
    public string NomeProduto { get; set; }
    public int IdCompra { get; set; }
    public decimal Valor { get; set; }
    public string? Categoria { get; set; }
    public DateTime Data { get; set; }
    public string? Descricao { get; set; }
    public bool Pago { get; set; }

    private static int _contador = 0;

   public Despesa(string nomeProduto, decimal valor, string categoria)
    {
        NomeProduto = nomeProduto;
        Pago = false;
        IdCompra = _contador++;
        Valor = valor;
        Data = DateTime.Now;
        Categoria = categoria;
    }
}

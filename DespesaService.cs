namespace ControleDeGastos;

internal class DespesaService
{
   private List<Despesa> listaDespresa = new List<Despesa>();

   public void AdicionarProduto(string nomeProduto, decimal valorProduto, string categoriaProduto)
    {
        var novaCompra = new Despesa(nomeProduto, valorProduto, categoriaProduto);
        listaDespresa.Add(novaCompra);
    }

    public void ControlePagamento()
    {
        foreach(var novaDespesa in listaDespresa)
        {
            string estadoAprovacao;
            if(novaDespesa.Pago)
            {
                estadoAprovacao = "Já pago.";
            }else
            {
                estadoAprovacao = "Pagamento pendente";
            }
            Console.WriteLine($"Id da compra - {novaDespesa.IdCompra} - " +
                $"Nome do produto - {novaDespesa.NomeProduto} - " +
                $"Estado de pagamento - {estadoAprovacao}");          
        }
    }
    
    public void RealizarPagamento(int id)
    {
        foreach(var realizarPagamento in listaDespresa)
        {
            if (realizarPagamento.IdCompra.Equals(id))
            {
                realizarPagamento.Pago = true;
                break;
            }
        }
    }

    public void RemoverDespesa(int id)
    {
        foreach (var despesas in listaDespresa)
        {
            if (despesas.IdCompra.Equals(id)){
                listaDespresa.Remove(despesas);
                break;
            }
        }
    }

    public void DespesaTotal()
    {
        decimal despesaTotal = 0;

        foreach (var despesasASeremPagas in listaDespresa)
        {

            despesaTotal += despesasASeremPagas.Valor;
        }
        Console.WriteLine($"Total a ser pago: R$ {despesaTotal}");
    }

    public void ListarPorCategoria(string categoria)
    {
        var resultado = listaDespresa.Where(d => d.Categoria == categoria);
        Console.WriteLine($"Total encontrado: {resultado.Count()}");
        Console.WriteLine("---Lista por categoria---");
        foreach(var despesaPorCategoria in resultado)
        {
            Console.WriteLine($"Nome do produto: {despesaPorCategoria.NomeProduto} - " +
                $"Valor do produto: {despesaPorCategoria.Valor} - " +
                $"Pamento - {despesaPorCategoria.Pago}");
        }
    }
}

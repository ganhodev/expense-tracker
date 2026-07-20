using ControleDeGastos.Domain;

namespace ControleDeGastos.Repository;
public class GastoRepository
{
    private static List<Gasto> _gastos = new();

    public void Adicionar(Gasto gasto) => _gastos.Add(gasto);
    public List<Gasto> ListarTodos() => _gastos;
    public void Remover(Guid id) => _gastos.RemoveAll(g => g.Id == id);
}

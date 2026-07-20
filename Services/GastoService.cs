using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using FluentValidation;

namespace ControleDeGastos.Services;

public class GastoService
{
    private readonly GastoRepository _gastoRepository;
    private readonly IValidator<Gasto> _validator;

    public GastoService(GastoRepository gastoRepository, IValidator<Gasto> validator)
    {
        _gastoRepository = gastoRepository;
        _validator = validator;
    }

    public void Adicionar(Gasto gasto)
    {
        var resultado = _validator.Validate(gasto);
        if (!resultado.IsValid)
        {
            throw new ValidationException(resultado.Errors);
        }

        _gastoRepository.Adicionar(gasto);
    }

    public List<Gasto> ListarTodos() => _gastoRepository.ListarTodos();

    public void Remover(Guid id) => _gastoRepository.Remover(id);

    public Dictionary<string, decimal> TotalPorCategoria()
    {
        return _gastoRepository.ListarTodos().GroupBy(c => c.Categoria)
            .ToDictionary
            (grupo => grupo.Key, grupo => grupo.Sum(gasto => gasto.Valor));
    }
}

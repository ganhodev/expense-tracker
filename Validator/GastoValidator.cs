namespace ControleDeGastos.Validator;

using ControleDeGastos.API.Domain;
using FluentValidation;
using global::ControleDeGastos.Domain;
public class GastoValidator : AbstractValidator<Gasto>
{
    public GastoValidator()
    {
        RuleFor(g => g.Descricao)
            .NotEmpty()
            .MinimumLength(5);

        RuleFor(g => g.Valor)
            .GreaterThan(0);

        RuleFor(d => d.Data)
            .LessThanOrEqualTo(DateTime.UtcNow);
    }
}

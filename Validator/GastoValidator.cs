namespace ControleDeGastos.Validator;

using ControleDeGastos.Domain;
using FluentValidation;

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
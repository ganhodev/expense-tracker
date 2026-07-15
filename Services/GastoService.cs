
using ControleDeGastos.API.Domain;
using ControleDeGastos.API.Repository;
using FluentValidation;
using global::ControleDeGastos.Domain;
using global::ControleDeGastos.Repository;
using System.ComponentModel.DataAnnotations;

namespace ControleDeGastos.Services;
public class GastoService
{
    //Isso serve pra guardar as dependências que vêm de fora (via construtor) e
    //deixar elas disponíveis pra qualquer método da classe usar depois.
    //Sem esses campos, o gastoRepository e o validator que recebe no construtor
    //somem assim que o construtor termina de executar — eles são só parâmetros locais, existem apenas aqui dentro.


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
}

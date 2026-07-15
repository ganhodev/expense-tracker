namespace ControleDeGastos.Controllers;

using ControleDeGastos.API.Domain;
using ControleDeGastos.API.Services;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace ControleDeGastos.API.Controllers;

    [ApiController]
    [Route("api/gastos")]
public class GastosController(GastoService gastoService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AdicionarGasto([FromBody] Gasto gasto)
    {
        try
        {
        gastoService.Adicionar(gasto);
        return Ok();
        }
        catch(ValidationException ex)
        {
            return BadRequest(ex.Errors);
        }
    }
}
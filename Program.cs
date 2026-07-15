using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Services;
using ControleDeGastos.Validator;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a Controllers
builder.Services.AddControllers();

// Registra suas classes no container de Injeção de Dependência
builder.Services.AddScoped<GastoRepository>();
builder.Services.AddScoped<GastoService>();
builder.Services.AddScoped<IValidator<Gasto>, GastoValidator>();

// Swagger (documentação automática da API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilita o Swagger só em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia os endpoints dos Controllers
app.MapControllers();

app.Run();
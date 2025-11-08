using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PatioApi.Data;
using PatioApi.Services;
using PatioApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// ----------------------
// DATABASE
// ----------------------
builder.Services.AddDbContext<PatioContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection"))
);

// ----------------------
// CONTROLLERS + VERSIONING
// ----------------------
builder.Services.AddControllers();

builder.Services.AddApiVersioning(o =>
{
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    o.ReportApiVersions = true;
});

// ----------------------
// HEALTHCHECKS
// ----------------------
builder.Services.AddHealthChecks();

// ----------------------
// SWAGGER (FULL CONFIG)
// ----------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Patio API",
        Version = "v1",
        Description = "API do sistema de pátio (Motos, Operadores e Movimentações)"
    });
});

// ----------------------
// DEPENDENCY INJECTION
// ----------------------
builder.Services.AddScoped<MotoService>();
builder.Services.AddScoped<MovimentacaoService>();
builder.Services.AddScoped<OperadorService>();

builder.Services.AddScoped<MotoRepository>();
builder.Services.AddScoped<MovimentacaoRepository>();
builder.Services.AddScoped<OperadorRepository>();

var app = builder.Build();

// ----------------------
// MIDDLEWARE
// ----------------------
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Patio API v1");
    c.RoutePrefix = "swagger"; // URL: /swagger
});

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.MapGet("/", () => "API do Pátio funcionando!");

app.Run();

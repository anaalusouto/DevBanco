using CadastroClienteEmprestimo.Core.Interface;
using CadastroClienteEmprestimo.Core.UseCase;
using CadastroClienteEmprestimo.Infra;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PrimaryConnection"));
});

builder.Services.AddScoped<ICadastrarClienteUseCase, CadastrarClienteUseCase>();
builder.Services.AddScoped<IObterClientePorIdUseCase, ObterClientePorIdUseCase>();
builder.Services.AddScoped<IAtualizarClienteUseCase, AtualizarClienteUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

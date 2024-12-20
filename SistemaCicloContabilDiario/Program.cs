using Microsoft.EntityFrameworkCore;
using SistemaCicloContabilDiario.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// container de servi�os de inje��o de depend�ncia do ASP.NET Core
//AddDbContext<AppDbContext>Registra o AppDbContext como um servi�o para inje��o de depend�ncia.
//Vai injetado em classes como controladores ou reposit�rios, permitindo o acesso ao banco de dados
//depois de configurado acessar Console de Gerenciador de Pct Nuget e "add-migration CriandoDB"
//cria as migrations na pasta Migrations
// "update-database"
builder.Services.AddDbContext<AppDbContext>(options =>
{
    //Obt�m a string de conex�o chamada DefaultConnection a partir do arquivo de configura��o da aplica��o
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

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

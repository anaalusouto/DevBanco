
using ClienteCRUD.Core.Interfaces.Adapters;
using ClienteCRUD.Crosscutting;
using ClienteCRUD.Data;
using ClienteCRUD.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClienteCRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkNpgsql()
                .AddDbContext<UserCRUD_DBContext>(
                    options => options.UseNpgsql(builder.Configuration.GetConnectionString("Database"))
                );

            builder.Services.AddInjections();

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
        }
    }
}

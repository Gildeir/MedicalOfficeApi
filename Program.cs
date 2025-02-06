
using MedicalOfficeApi.Context;
using MedicalOfficeApi.Controllers;
using MedicalOfficeApi.Repository;
using MedicalOfficeApi.Repository.Interfaces;
using MedicalOfficeApi.Services;
using Microsoft.EntityFrameworkCore;

namespace MedicalOfficeApi
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
            builder.Services.AddScoped<IEmailService, EmailService>();

            builder.Services.AddScoped<IBaseRepository, BaseRepository>();
            builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();

            builder.Services.AddDbContext<MediaOfficeContext>(options =>
            {
                // 1. Get the connection string from configuration
                string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

                // 2. Use the correct UseSqlServer overload
                options.UseSqlServer(connectionString);

                // Important: Handle any potential exceptions during connection string retrieval.
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("The 'DefaultConnection' connection string is not configured.");
                }
            });



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

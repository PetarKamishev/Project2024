using Project2024.Project2024.BL.Interfaces;
using Project2024.Project2024.BL.Services;
using Project2024.Project2024.DL.Interfaces;
using Project2024.Project2024.DL.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Project2024
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
            builder.Services.AddSingleton<IItemsRepository, ItemsRepository>();
            builder.Services.AddSingleton<IItemsService, ItemsService>();
            builder.Services.AddSingleton<IBrandsRepository, BrandsRepository>();
            builder.Services.AddSingleton<IBrandsService, BrandsService>();
            builder.Services.AddSingleton<IStoreService, StoreService>();
            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
            builder.Services.AddHealthChecks();
            


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.MapHealthChecks("/healthz");
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
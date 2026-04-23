using BikeStores.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies; // Add this using to bring UseLazyLoadingProxies extension into scope

namespace BikeStores.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Ensure the Microsoft.EntityFrameworkCore.Proxies NuGet package is installed for UseLazyLoadingProxies to be available.
            builder.Services.AddDbContext<BikeStoresContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("local"))
                .UseLazyLoadingProxies()
                );

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

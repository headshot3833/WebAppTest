
using WebApp.Aplication.Services;
using WebApp.AplicationCalculator.Services;

namespace WebApp.Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<PlusService>();
            builder.Services.AddSingleton<DivideService>();
            builder.Services.AddSingleton<MultiplicationService>();
            builder.Services.AddSingleton<MinusService>();
            builder.Services.AddSingleton<ServiceCalculator>();
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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

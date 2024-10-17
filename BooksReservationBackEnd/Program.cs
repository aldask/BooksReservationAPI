using BooksReservationBackEnd.DB;
using Microsoft.EntityFrameworkCore;
using BooksReservationBackEnd.Service;

namespace BooksReservationBackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AppDB>(options => options.UseInMemoryDatabase("Library"));
            builder.Services.AddScoped<ReserveCalc>();

            //Cors config
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
            app.UseCors("AllowAllOrigins");
            app.UseAuthorization();
            app.MapControllers();

            InitializeDatabase(app);

            app.Run();
        }

        private static void InitializeDatabase(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDB>();
                    context.Database.EnsureCreated();
                }
                catch (Exception error)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(error, "An error occurred creating the database.");
                }
            }
        }
    }
}
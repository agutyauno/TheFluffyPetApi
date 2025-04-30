using Swashbuckle.AspNetCore.SwaggerGen;

namespace TheFluffyPetApi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options => {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins("http://127.0.0.1:5501")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            // Add HTTPS configuration
            builder.WebHost.ConfigureKestrel(serverOptions =>
            {
                serverOptions.ListenLocalhost(5200); // HTTP
                serverOptions.ListenLocalhost(5201, listenOptions =>
                {
                    listenOptions.UseHttps();
                }); // HTTPS
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            // Thêm Swagger
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "The Fluffy Pet API",
                    Version = "v1",
                    Description = "An API for managing pets"
                });
            });

            WebApplication app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "The Fluffy Pet API V1");
                });
            }

            app.UseHttpsRedirection();
            app.UseCors();
            app.MapControllers();
            app.Run();
        }
    }
}

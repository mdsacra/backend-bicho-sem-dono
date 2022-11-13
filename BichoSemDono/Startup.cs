using System.Text;
using BichoSemDono.Core.Authentication;
using BichoSemDono.Core.Infrastructure.ContextConfiguration;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BichoSemDono;

public class Startup
{
    public IConfiguration Configuration { get; }
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        
        services.AddMediatR(typeof(Startup));
        
        services.AddDbContext<BichoSemDonoContext>(options =>
        {
            options.UseNpgsql(Configuration.GetConnectionString("Default"));
        });

        services.AddSwaggerGen();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseCors(builder => builder
            .WithOrigins(Configuration.GetSection("AllowedOrigins").Get<string[]>())
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
        
        app.UseHttpsRedirection();
        
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")?.Contains("Development") == true)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        
        app.UseAuthorization();
        
        app.UseEndpoints(endpoints 
            => endpoints.MapControllers());
    }
}
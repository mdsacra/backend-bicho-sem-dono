using System.Text;
using BichoSemDono.Core.Authentication;
using BichoSemDono.Core.Infrastructure.ContextConfiguration;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
        
        var key = Encoding.ASCII.GetBytes(Settings.Secret);
        services.AddAuthentication(o =>
        {
            o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(o =>
        {
            o.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
        
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

        app.UseAuthentication();
        app.UseAuthorization();
        
        app.UseEndpoints(endpoints 
            => endpoints.MapControllers());
    }
}
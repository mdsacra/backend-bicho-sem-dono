﻿using BichoSemDono.Core.Infrastructure;
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

        services.AddDbContext<BichoSemDonoContext>(options =>
        {
            options.UseNpgsql(Configuration.GetConnectionString("Default"));
        });

        services.AddSwaggerGen();
    }

    public void Configure(IApplicationBuilder app)
    {
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
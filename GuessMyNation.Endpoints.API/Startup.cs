using GuessMyNation.Core.ApplicationServices.NationItems;
using GuessMyNation.Core.ApplicationServices.Nations;
using GuessMyNation.Core.Domain.Nation;
using GuessMyNation.Core.Domain.NationItems;
using GuessMyNation.Infra.Data.Sql.Common;
using GuessMyNation.Infra.Data.Sql.NationItems;
using GuessMyNation.Infra.Data.Sql.Nations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GuessMyNation.Endpoints.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GuessMyNation.Endpoints.API", Version = "v1" });
            });

            services.AddDbContext<GuessMyNationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("GuessMyNationCnn")));            
           
            services.AddScoped<NationRepository, EfNationRepository>();            
            services.AddScoped<NationApplicationService>();

            services.AddScoped<NationItemRepository, EfNationItemRepository>();
            services.AddScoped<NationItemApplicationService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GuessMyNation.Endpoints.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using ApiRest.Repo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ApiRest
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
            var connectionSql = new DataAccess(Configuration.GetConnectionString("SQL"));
            services.AddSingleton(connectionSql);
            
            services.AddSingleton<IMemoryProduct, SqlProducts>(); //Dependency Injection Db
            // services.AddSingleton<IMemoryProduct, MemoryProduct>(); //Dependency Injection Linq

<<<<<<< HEAD
            //services.AddControllers(options => { options.SuppressAsyncSuffixInActionNames=false})//parara evitar problemas(?
            services.AddControllers();
=======
            services.AddControllers(options => options.SuppressAsyncSuffixInActionNames = false); //options => options.SuppressAsyncSuffixInActionNames = false por si da problemas con postman
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiRest", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiRest v1"));
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

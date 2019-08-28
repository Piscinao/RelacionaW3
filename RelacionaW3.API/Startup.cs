using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RelacionaW3.Repositorio;


namespace RelacionaW3.API
{
    public class Startup
    {
        //injeção de dependecia
        //configuration le o appsettings,json
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //Injection meio entre o banco e a app - middleware
        //camada entre o fim e o client
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RelacionaW3Context>(options =>
            options.UseSqlServer(Configuration["Data:UCASAppDatabase:ConnectionString"]));
            services.AddScoped<IRelacionaW3Repositorio, RelacionaW3Repositorio>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            //cors requisicao http
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}

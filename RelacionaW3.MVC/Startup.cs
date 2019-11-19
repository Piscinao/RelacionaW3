using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Repositorio.Entidades;
using Aplicacao.Servico.Interfaces;
using Aplicacao.Servico;
using Dominio.Interfaces;
using Dominio.Servicos;
using Dominio.Repositorio;
using RelacionaW3.Dominio.Entidades;
using RelacionaW3.MVC.Entidades;
using Repositorio.Contexto;

namespace RelacionaW3.MVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Adiciona o context do DAL e referencia a string do banco que esá no json appsettings
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("Relaciona")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddHttpContextAccessor();
            services.AddSession();

           // services.AddIdentity<UsuarioTeste, NiveisAcesso>().AddDefaultUI().AddEntityFrameworkStores<Contexto>();

            services.ConfigureApplicationCookie(opcoes =>
            {
                // Habilitar cookie via http
                opcoes.Cookie.HttpOnly = true;
                // Tempo de expiração dos cookies
                opcoes.ExpireTimeSpan = TimeSpan.FromMinutes(50);
                // Url de Login
                opcoes.LoginPath = "/Usuarios/Login";
                // Quando expirar fazer novos cookies
                opcoes.SlidingExpiration = true;
            });

            services.Configure<IdentityOptions>(opcoes =>
            {
                opcoes.Password.RequireDigit = false;
                opcoes.Password.RequireLowercase = false;
                opcoes.Password.RequireNonAlphanumeric = false;
                opcoes.Password.RequireUppercase = false;
                opcoes.Password.RequiredLength = 6;
                opcoes.Password.RequiredUniqueChars = 1;
            });
                


            //Padrao de projeto que diz que um classe irá conter apenas uma instância
            //Toda a vez que chama a classe irá chamar a mesma instancia
            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
           

            // TENTATIVA DE USER COM ROLES

            // INJEÇÃO DE DEPENDÊNCIA
            // Serviço Aplicação
            services.AddScoped<IServicoAplicacaoArea, ServicoAplicacaoArea>();
            services.AddScoped<IServicoAplicacaoPessoa, ServicoAplicacaoPessoa>();
            services.AddScoped<IServicoAplicacaoEvento, ServicoAplicacaoEvento>();
            services.AddScoped<IServicoAplicacaoResposta, ServicoAplicacaoResposta>();
            services.AddScoped<IServicoAplicacaoUsuario, ServicoAplicacaoUsuario>();

            // Domínio
            services.AddScoped<IServicoArea, ServicoArea>();
            services.AddScoped<IServicoPessoa, ServicoPessoa>();
            services.AddScoped<IServicoEvento, ServicoEvento>();
            services.AddScoped<IServicoResposta, ServicoResposta>();
            services.AddScoped<IServicoUsuario, ServicoUsuario>();

            // Repositorio
            //                                   classe concreta
            services.AddScoped<IRepositorioArea, RepositorioArea>();
            services.AddScoped<IRepositorioPessoa, RepositorioPessoa>();
            services.AddScoped<IRepositorioEvento, RepositorioEvento>();
            services.AddScoped<IRepositorioResposta, RepositorioResposta>();
            services.AddScoped<IRepositorioRespostaEventos, RepositorioRespostaEventos>();
            services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();
            
            // app.UseAuthentication();
            

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}

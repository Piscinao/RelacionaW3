using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RelacionaW3.Repositorio.Interfaces;
using RelacionaW3.Repositorio.Entidades;
using RelacionaW3.Repositorio;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Servicos;

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
            // services.Configure<CookiePolicyOptions>(options =>
            // {
                
            //     options.CheckConsentNeeded = context => true;
            //     options.MinimumSameSitePolicy = SameSiteMode.None;
            // });

            //Adiciona o context do DAL e referencia a string do banco que esá no json appsettings
            //    services.AddDbContext<ApplicationDbContext>(options =>
            //     options.UseSqlServer(
            //         Configuration.GetConnectionString("Relaciona")));


                services.AddDbContext<Context>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("Relaciona")));
            // services.AddDefaultIdentity<Id entityUser>()
            //     .AddDefaultUI(UIFramework.Bootstrap4)
            //     .AddEntityFrameworkStores<ApplicationDbContext>();
            // services.AddDbContext<ApplicationDbContext2>(options =>
            //     options.UseSqlServer(
            //         Configuration.GetConnectionString("Relaciona")));

            // services.AddDefaultIdentity<IdentityUser>()
            //     .AddDefaultUI(UIFramework.Bootstrap4)
            //     .AddEntityFrameworkStores<Contexto>();


            // services.AddDbContext<Contexto>(options => options.UseSqlServer(Configuration.GetConnectionString("Relaciona")));

            // services.AddHttpContextAccessor();
           

            services.AddIdentity<Usuario, NivelAcesso>().AddEntityFrameworkStores<Context>();

            services.ConfigureApplicationCookie(opcoes =>
            {
                // Habilitar cookie via http
                opcoes.Cookie.HttpOnly = true;
                // Tempo de expiração dos cookies
                opcoes.ExpireTimeSpan = TimeSpan.FromMinutes(100);
                // Url de Login
             
                opcoes.LoginPath = $"/Usuario/Login";
                opcoes.LogoutPath = $"/Usuario/Login";
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
           
            // services.AddScoped<IServicoAplicacaoPessoa, ServicoAplicacaoPessoa>();
            // services.AddScoped<IServicoAplicacaoEvento, ServicoAplicacaoEvento>();
            // services.AddScoped<IServicoAplicacaoResposta, ServicoAplicacaoResposta>();
          



            // Domínio
           
            // services.AddScoped<IServicoPessoa, ServicoPessoa>();
            
            // services.AddScoped<IServicoResposta, ServicoResposta>();
            
            // Repositorio
            //                                   classe concreta
         
            services.AddScoped<IEventoRepositorio, EventoRepositorio>();
            services.AddScoped<IPessoaRepositorio, PessoaRepositorio>();
            services.AddScoped<IAreaRepositorio, AreaRepositorio>();
            services.AddScoped<IAreaResponsavelRepositorio, AreaResponsavelRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<INivelAcessoRepositorio, NivelAcessoRepositorio>();
            services.AddScoped<IRespostaRepositorio, RespostaRepositorio>();


            services.Configure<ConfiguracoesEmail>(Configuration.GetSection("ConfiguracoesEmail"));
            services.AddScoped<IEmail, Email>();
        
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
            // app.UseSession();
            app.UseAuthentication();
          
            

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Usuario}/{action=Login}/{id?}");
            });
        }
    }
}

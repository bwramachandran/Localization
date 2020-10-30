using LocalizationTools.Data.LocAPI;
using LocalizationTools.Data.Logging;
using LocalizationTools.Data.RDB.Functions;
using LocalizationTools.Data.RDB.Models;
using LocalizationTools.Data.RDB.StoredProcedure;
using LocalizationTools.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LocalizationTools
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddControllers();
           
            services.AddTransient<IDataServiceLocAPI, DataServiceLocAPI>();
            services.AddTransient<ILocAPIService,LocAPIService>();
            services.AddTransient<IFunction, Function>();
            services.AddTransient<IProcedure, Procedure>();
            services.AddTransient<IPaginationService, PaginationService>();
            var connection = Configuration["ConnectionString:bwloctools"];
            services.AddDbContext<bw_loc_dylan_devContext>(options => options
             .UseSqlServer(connection, o => o.EnableRetryOnFailure(10)));
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "Localization Tools REST API";
                    document.Info.Description = "LocVo Tools";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Bioware - Localization Team",
                        Email = string.Empty,
                    };
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/localizationToolsLog-{Date}.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseLocalizationToolsExceptionMiddleWare();
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseOpenApi();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}

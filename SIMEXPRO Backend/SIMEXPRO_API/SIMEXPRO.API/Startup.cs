using AutoMapper;
//using Events_Company_R.API.Extentions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SIMEXPRO.API.Extentions;
using SIMEXPRO.API.Middleware;
using SIMEXPRO.BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API
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
            services.AddCors(option =>
            {
                option.AddPolicy("AllowFlutter", builder =>
                {
                    builder.WithOrigins("http://localhost:3000", 
                                        "https://simexpro.onrender.com",
                                        "https://simexpro.vercel.app",
                                        "https://simexpro.up.railway.app") //NOMBRE DEL SERVIDOR
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("Authorization");
                }
                );
            }
           );

            // Configure Azure Key Vault
            //var configBuilder = new ConfigurationBuilder();
            //var keyVaultEndpoint = "https://simexpro.vault.azure.net/"; // Replace with your Key Vault URI
            //var azureServiceTokenProvider = new AzureServiceTokenProvider();
            //var keyVaultClient = new KeyVaultClient(
            //    new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback)
            //);
            //configBuilder.AddAzureKeyVault(keyVaultEndpoint, keyVaultClient, new DefaultKeyVaultSecretManager());

            ////Add your other configuration sources, e.g., appsettings.json, user secrets, etc.
            //configBuilder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //            .AddUserSecrets<Startup>()
            //            .AddEnvironmentVariables();

            //var configuration = configBuilder.Build();
            //services.AddSingleton(configuration);


            services.DataAccess(Configuration.GetConnectionString("ConexionSimexpro"));
            services.BussinessLogic();
            services.AddAutoMapper(x => x.AddProfile<MappingProfileExtensions>(), AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();

            services.AddMvc();
            services.AddControllersWithViews();
            services.AddControllers();
            AddSwagger(services);
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Foo {groupName}",
                    Version = groupName,
                    Description = "Foo API",
                    Contact = new OpenApiContact
                    {
                        Name = "Foo Company",
                        Email = string.Empty,
                        Url = new Uri("https://foo.com/"),
                    }
                });

                //options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                //{
                //    Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
                //    In = ParameterLocation.Header,
                //    Name = "Authorization",
                //    Type = SecuritySchemeType.ApiKey,
                //    //    Scheme = "ApiKeyScheme"
                //});

                options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
                {
                    Description = "ApiKey must appear in header",
                    Type = SecuritySchemeType.ApiKey,
                    Name = "XApiKey",
                    In = ParameterLocation.Header,
                    Scheme = "ApiKeyScheme"
                });
                var key = new OpenApiSecurityScheme()
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "ApiKey"
                    },
                    In = ParameterLocation.Header
                };
                var requirement = new OpenApiSecurityRequirement
                    {
                             { key, new List<string>() }
                    };
                options.AddSecurityRequirement(requirement);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MAVEX.WEBUI v1"));
                //app.UseHttpsRedirection();
            }

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Events_Company_R.API v1");
            });
            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Foo API V1");
                c.EnableValidator();
            });
            app.UseRouting();

            //ADD SELVIN
            app.UseCors("AllowFlutter");

            app.UseAuthorization();

            app.UseMiddleware<ApiKeyMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Villa.Domain.Settings;
using Villa.Infrastructure.Mapping;
using Villa.Persistence;
using Villa.Service.Contract;
using Villa.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using Villa.Domain.Interfaces;
using Villa.Persistence.Repositories;
using Newtonsoft.Json;

namespace Villa.Infrastructure.Extension
{
    public static class ConfigureServiceContainer
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
             IConfiguration configuration, IConfigurationRoot configRoot)
        {
            serviceCollection.AddDbContext<appDbContext>(options => {
                //options.EnableSensitiveDataLogging();
                options.UseNpgsql(configuration.GetConnectionString("OnionArchConn") ?? configRoot["ConnectionStrings:OnionArchConn"]
             , b => b.MigrationsAssembly(typeof(appDbContext).Assembly.FullName));

                 });
        }

        public static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }

        public static void AddScopedServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAppDbContext>(provider => provider.GetService<appDbContext>());
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDateTimeService, DateTimeService>();
            serviceCollection.AddTransient<IAccountService, AccountService>();
            serviceCollection.AddTransient<IRoleService, RoleService>();
            serviceCollection.AddTransient<IBolgeService, BolgeService>();
            serviceCollection.AddTransient<IKategoriService, KategoriService>();
            serviceCollection.AddTransient<IVillaService, VillaService>();
            serviceCollection.AddTransient<IVillaIcerikService, VillaIcerikService>();
            serviceCollection.AddTransient<IVillaLokasyonService, VillaLokasyonService>();
            serviceCollection.AddTransient<IVillaImageService, VillaImageService>();
            serviceCollection.AddTransient<IVillaPeriyodikFiyatService, VillaPeriyodikFiyatService>();
            serviceCollection.AddTransient<IVillaPeriyodikFiyatAyarlariService, VillaPeriyodikFiyatAyarlariService>();
            serviceCollection.AddTransient<IVillaLokasyonService, VillaLokasyonService>();
            serviceCollection.AddTransient<IIlService, IlService>();
            serviceCollection.AddTransient<IIlceService, IlceService>();
            serviceCollection.AddTransient<IMulkService, MulkService>();
        }
        public static void AddSwaggerOpenAPI(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSwaggerGen(setupAction =>
            {

                setupAction.SwaggerDoc(
                    "OpenAPISpecification",
                    new OpenApiInfo()
                    {
                        Title = "Onion Architecture WebAPI",
                        Version = "1",
                        Description = "Through this API you can access customer details",
                        Contact = new OpenApiContact()
                        {
                            Email = "Villa@Villa.com",
                            Name = "Villa PTS",
                            Url = new Uri("https://Villa.com.tr/")
                        },
                    });

                setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Description = $"Input your Bearer token in this format - Bearer token to access this API",
                });
                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer",
                            },
                        }, new List<string>()
                    },
                });
            });

        }

        public static void AddMailSetting(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            serviceCollection.Configure<MailSettings>(configuration.GetSection("MailSettings"));
        }

        public static void AddController(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddControllers().AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
        }

        public static void AddVersion(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }

        public static void AddHealthCheck(this IServiceCollection serviceCollection, AppSettings appSettings, IConfiguration configuration)
        {
            // serviceCollection.AddHealthChecks()
            //     .AddDbContextCheck<appDbContext>(name: "Application DB Context", failureStatus: HealthStatus.Degraded)
            //     .AddUrlGroup(new Uri(appSettings.ApplicationDetail.ContactWebsite), name: "My personal website", failureStatus: HealthStatus.Degraded)
            //     .AddSqlServer(configuration.GetConnectionString("OnionArchConn"));
            
            serviceCollection.AddHealthChecksUI(setupSettings: setup =>
            {
                setup.AddHealthCheckEndpoint("Basic Health Check", $"/healthz");
            }).AddInMemoryStorage();
        }


    }
}

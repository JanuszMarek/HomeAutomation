using AutoMapper;
using HomeAutomation.AutoMapper;
using HomeAutomation.Extensions;
using HomeAutomation.Filters;
using HomeAutomation.Models.Configuration;
using HomeAutomation.Models.Context;
using HomeAutomation.Models.Entities;
using HomeAutomation.Providers;
using HomeAutomation.Providers.Interfaces;
using HomeAutomation.Repositories;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace HomeAutomation
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
            services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddMemoryCache();
            services.ConfigureSwagger();

            //register Db Context
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(
                    Configuration["ConnectionString"]));

            //register AutoMapper
            services.AddAutoMapper(
                typeof(EntityToModelProfile), 
                typeof(ModelToEntityProfile));

            RegisterConfigClasses(services);
            RegisterRepositories(services);
            RegisterServices(services);
            RegisterFilters(services);
            RegisterResponseCache(services);
            RegisterProviders(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                DatabaseMigrationUpdate(app.ApplicationServices);

                app.UseSwaggerConfiguration();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void RegisterConfigClasses(IServiceCollection services)
        {
            services.Configure<AzureStorageConfig>(Configuration.GetSection("AzureStorageConfig"));
        }

        private void RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IDeviceRepository, DeviceRepository>();
            services.AddTransient<IDeviceTypeRepository, DeviceTypeRepository>();
            services.AddTransient<IProducerRepository, ProducerRepository>();
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddTransient<IDeviceService, DeviceService>();
            services.AddTransient<IDeviceTypeService, DeviceTypeService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProducerService, ProducerService>();
            services.AddTransient<ILookupService, LookupService>();
            services.AddTransient<IImageService, ImageService>();
        }

        private void RegisterFilters(IServiceCollection services)
        {
            services.AddScoped<ModelValidationFilter>();
            services.AddScoped<ModelExistFilter<Producer>>();
            services.AddScoped<ModelExistFilter<Category>>();
            services.AddScoped<ModelExistFilter<DeviceType>>();
            services.AddScoped<ModelExistFilter<Device>>();
        }

        private void RegisterProviders(IServiceCollection services)
        {
            services.AddTransient<IAzureBlobStorageProvider, AzureBlobStorageProvider>();
        }

        private void DatabaseMigrationUpdate(IServiceProvider services)
        {
            DatabaseUpdateMigrator.Migrate(services);
        }

        private void RegisterResponseCache(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.CacheProfiles.Add(ResponseCacheProfile.ShortTimeCache,
                    new CacheProfile()
                    {
                        Duration = ResponseCacheProfile.ShortTimeCacheDuration,
                        Location = ResponseCacheLocation.Client
                    });

                options.CacheProfiles.Add(ResponseCacheProfile.LongTimeCache,
                  new CacheProfile()
                  {
                      Duration = ResponseCacheProfile.LongTimeCacheDuration,
                      Location = ResponseCacheLocation.Client
                  });
            });
        }
    }
}

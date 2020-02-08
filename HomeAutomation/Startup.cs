using AutoMapper;
using HomeAutomation.AutoMapper;
using HomeAutomation.Models.Context;
using HomeAutomation.Repositories;
using HomeAutomation.Repositories.Interfaces;
using HomeAutomation.Services;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            services.AddControllers();

            //register Db Context
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(
                    Configuration["ConnectionString"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        protected void RegisterServicers(IServiceCollection services)
        {
            // repositories
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IDeviceRepository, DeviceRepository>();
            services.AddTransient<IDeviceTypeRepository, DeviceTypeRepository>();
            services.AddTransient<IProducerRepository, ProducerRepository>();

            // services
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            //services.AddTransient<ICategoryRepository, CategoryRepository>();
            //services.AddTransient<IDeviceRepository, DeviceRepository>();
            //services.AddTransient<IDeviceTypeRepository, DeviceTypeRepository>();
            services.AddTransient<IProducerService, ProducerService>();
        }
    }
}

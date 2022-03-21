using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationSystem
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
            services.AddSingleton<IBusDetailsDao, BusDetailsDao>();
            services.AddSingleton<IBusFareDao, BusFareDao>();
            services.AddSingleton<IBusScheduleDao, BusScheduleDao>();
            services.AddSingleton<IBusTypeDao, BusTypeDao>();
            services.AddSingleton<ICustomerDao, CustomerDao>();
            services.AddSingleton<IPaymentsDao, PaymentsDao>();
            services.AddSingleton<IRouteDetailsDao, RouteDetailsDao>();
            services.AddSingleton<IUserTypeDao, UserTypeDao>();
            services.AddSingleton<ITicketBookingDao, TicketBookingDao>();
            //services.AddSingleton<ITicketCancellationDao, TicketCancellationDao>();
            //services.AddSingleton<ITypeOfTicketDao, TypeOfTicketDao>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}


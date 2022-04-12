using Lumen.Training.Libraries.API.Controllers.Impl;
using Lumen.Training.Libraries.API.Controllers.Interfaces;
using Lumen.Training.Libraries.Business.Impl;
using Lumen.Training.Libraries.Business.Interfaces;
using Lumen.Training.Libraries.Business.Validations.Impl;
using Lumen.Training.Libraries.Business.Validations.Interfaces;
using Lumen.Training.Libraries.DAL.Impl;
using Lumen.Training.Libraries.DAL.Interfaces;
using Lumen.Training.Libraries.Repos.Impl;
using Lumen.Training.Libraries.Repos.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumen.Training.API.Hosting.CalculationAndOffers
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
            services.AddScoped<ICalculationOfferSystemContext, CalculationOfferSystemContext>();
            services.AddScoped<ICalculationOfferRequestRepository, CalculationOfferRequestRepository>();
            services.AddScoped<ICalculationOfferResponseRepository, CalculationOfferResponseRepository>();
            services.AddScoped<ICalcluationOfferRequestValidation, CalcluationOfferRequestValidation>();
            services.AddScoped<ICalculationOfferResponseValidation, CalcluationOfferResponseValidation>();
            services.AddScoped<ICalculationOfferProcessingBusinessComponent, CalculationOfferProcessingBusinessComponent>();
            services.AddScoped<ICalculationOfferServiceController, CalculationOfferServiceController>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Lumen.Training.API.Hosting.CalculationAndOffers", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lumen.Training.API.Hosting.CalculationAndOffers v1"));
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

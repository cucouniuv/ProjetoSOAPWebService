using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using SoapCore;
using WebSOAP.Models.Interfaces;

namespace WebSOAP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<ISampleService, SampleService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSoapEndpoint<ISampleService>("/Service.asmx",
                new BasicHttpBinding(), SoapSerializer.XmlSerializer);
        }
    }
}

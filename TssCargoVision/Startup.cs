using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoapCore;
using TssCargoVision.Configuration;
using TssCargoVision.Services;
using TssCargoVision.Wsdl;

namespace TssCargoVision
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<UnderlyingConnectionOptions>(_configuration.GetSection("UnderlyingConnection"));

            services.AddSoapCore();
            services.AddTransient<WsdlClient>();
            services.AddTransient<ICargoService, CargoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSoapEndpoint<ICargoService>(opts =>
            {
                opts.Path = "/cargoVision/service/index";
                opts.SoapSerializer = SoapSerializer.XmlSerializer;
                opts.Binding = new BasicHttpBinding();
            });
        }
    }
}

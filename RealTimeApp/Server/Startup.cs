using Microsoft.AspNetCore.Builder;

namespace RealTimeApp.Server {
    public class Startup {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) {

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSignalR();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) { 
            
            }
        }
    }
}

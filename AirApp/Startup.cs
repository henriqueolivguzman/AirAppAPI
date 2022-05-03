
using Data;
using Microsoft.EntityFrameworkCore;

namespace AirAppAPI
{
    public class Startup
    {
        public Startup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices (IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<ApplicationDBContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection")));
        }
    }
}

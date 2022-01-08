namespace e2eApplication.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class Installer
    {
        public static void AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<e2eDbContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                }
            );
        }
    }
}

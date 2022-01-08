using e2eApplication.Persistence.Models;

namespace e2eApplication.Persistence
{
    using Microsoft.EntityFrameworkCore;

    public class e2eDbContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecast => Set<WeatherForecast>();

        public e2eDbContext(DbContextOptions<e2eDbContext> options)
            : base(options)
        {
        }
    }
}

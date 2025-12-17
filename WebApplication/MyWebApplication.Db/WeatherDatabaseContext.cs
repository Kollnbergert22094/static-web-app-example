using Microsoft.EntityFrameworkCore;

namespace MyWebApplication.Db;

public class WeatherDatabaseContext : DbContext
{
    public WeatherDatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public WeatherDatabaseContext()
    {
    }

    public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("Server=tcp:sql-server-kollnbergert22094.database.windows.net,1433;Initial Catalog=sql-database-kollnbergert22094;Persist Security Info=False;User ID=kollnbergt22094;Password=htlgkr1#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}

using Microsoft.EntityFrameworkCore;

namespace KBO_Dictionary.DataAccessLayer;

public class KboDbContext : DbContext
{
    private const string Host = "localhost";
    private const string User = "postgres";
    private const string DbName = "postgres";
    private const string Password = "991105";
    private const string Port = "5432";
    public DbSet<PlayerInformationEntity> PlayerInformation { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql($"Host={Host}:{Port};Database={DbName};Username={User};Password={Password}");
    }
}
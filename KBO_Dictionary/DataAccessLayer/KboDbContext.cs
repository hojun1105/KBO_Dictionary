using KBO_Dictionary.BusinessLogicLayer;
using KBO_Dictionary.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KBO_Dictionary.DataAccessLayer;

public class KboDbContext : DbContext
{
    private const string Host = "localhost";
    private const string User = "postgres";
    private const string DbName = "postgres";
    private const string Password = "991105";
    private const string Port = "5432";
    public DbSet<PlayerInformationEntity>? PlayerInformation { get; set; }
    public DbSet<StatInformationEntity>? StatInformation { get; set; }
    public DbSet<TeamInformationEntity>? TeamInformation { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlayerInformationDao>().ToTable("PLAYER_INFO", schema: "KBO");
        modelBuilder.Entity<StatInformationEntity>().ToTable("STAT_INFO", schema: "KBO");
        modelBuilder.Entity<TeamInformationEntity>().ToTable("TEAM_INFO", schema: "KBO");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql($"Server={Host};Port={Port};User Id={User};Password={Password};Database={DbName}");
        base.OnConfiguring(optionsBuilder);
    }
}



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
    public DbSet<PlayerInformationEntity> PlayerInformation { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql($"Host={Host}:{Port};Database={DbName};Username={User};Password={Password}");
    }
}

public class PlayerStatRepository : IPlayerStatRepository
{
    public List<PlayerModel> SelectAllPlayerModels()
    {
        using (var context = new KboDbContext())
        {
            var playerInformationList = context.PlayerInformation.ToList();
            //todo : statinfo, teaminfo 다 가져와서 join후 PlayerModel로 변환후 return 
        }
    }
}

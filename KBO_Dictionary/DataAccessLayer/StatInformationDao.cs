using System.Linq;
using KBO_Dictionary.BusinessLogicLayer;
using KBO_Dictionary.EntityLayer;

namespace KBO_Dictionary.DataAccessLayer;

public class StatInformationDao : IStatInformationDao
{
    private readonly KboDbContext _dbContext = new();

    public void Insert(StatInformationEntity entity)
    {
        _dbContext.StatInformation.Add(entity);
        _dbContext.SaveChanges();
    }

    public void Update(StatInformationEntity entity)
    {
        var statInformation = _dbContext.StatInformation.Single(a => a.Id == entity.Id);
        statInformation.Games = entity.Games;
        statInformation.PlateAppearance = entity.PlateAppearance;
        statInformation.AtBat = entity.AtBat;
        statInformation.Run = entity.Run;
        statInformation.Hit = entity.Hit;
        statInformation.DoubleHit = entity.DoubleHit;
        statInformation.TripleHit = entity.TripleHit;
        statInformation.HomeRun = entity.HomeRun;
        statInformation.RunsBattedIn = entity.RunsBattedIn;
        statInformation.SluggingPercentage = entity.SluggingPercentage;
        statInformation.OnBasePercentage = entity.OnBasePercentage;
        statInformation.OnBasePlusSlugging = entity.OnBasePlusSlugging;
        statInformation.Average = entity.Average;
        _dbContext.SaveChanges();
    }

    public void Delete(StatInformationEntity entity)
    {
        _dbContext.StatInformation.Remove(entity);
        _dbContext.SaveChanges();
    }
}
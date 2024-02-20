using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.BusinessLogicLayer;
using KBO_Dictionary.EntityLayer;

namespace KBO_Dictionary.DataAccessLayer
{
    public class TeamInformationDao : ITeamInformationDao
    {
        private readonly KboDbContext _dbContext = new();

        public void Insert(TeamInformationEntity entity)
        {
            _dbContext.TeamInformation.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TeamInformationEntity entity)
        {
            var teamInformationEntity = _dbContext.TeamInformation.Single(a => a.Id == entity.Id);
            teamInformationEntity.Name = entity.Name;
            _dbContext.SaveChanges();
        }

        public void Delete(TeamInformationEntity entity)
        {
            _dbContext.TeamInformation.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}

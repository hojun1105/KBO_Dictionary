using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.BusinessLogicLayer;
using KBO_Dictionary.EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace KBO_Dictionary.DataAccessLayer
{
    public class TeamInformationDao : ITeamInformationDao
    {
        private readonly KboDbContext _dbContext = new();

        public List<TeamInformationEntity> SelectAll()
        {
            return _dbContext.TeamInformation?.ToList();
        }

        public void Insert(TeamInformationEntity entity)
        {
            _dbContext.TeamInformation?.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TeamInformationEntity entity)
        {
            _dbContext.TeamInformation!.Where(a => a.Id == entity.Id).ExecuteUpdate(setters =>
                setters.SetProperty(a => a.Name, entity.Name).SetProperty(a => a.TeamImage, entity.TeamImage));
        }

        public void Delete(TeamInformationEntity entity)
        {
            _dbContext.TeamInformation?.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}

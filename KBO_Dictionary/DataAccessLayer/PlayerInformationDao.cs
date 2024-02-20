using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.BusinessLogicLayer;
using KBO_Dictionary.EntityLayer;

namespace KBO_Dictionary.DataAccessLayer
{
    class PlayerInformationDao : IPlayerInformationDao
    {
        private readonly KboDbContext _dbContext = new();

        public void Insert(PlayerInformationEntity entity)
        {
            _dbContext.PlayerInformation.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(PlayerInformationEntity entity)
        {
            var playerInformationEntity = _dbContext.PlayerInformation.Single(a => a.Id == entity.Id);
            playerInformationEntity.Name = entity.Name;
            playerInformationEntity.BirthDate = entity.BirthDate;
            playerInformationEntity.Height = entity.Height;
            playerInformationEntity.TeamId = entity.TeamId;
            playerInformationEntity.Weight = entity.Weight;
            _dbContext.SaveChanges();
        }

        public void Delete(PlayerInformationEntity entity)
        {
            _dbContext.PlayerInformation.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}

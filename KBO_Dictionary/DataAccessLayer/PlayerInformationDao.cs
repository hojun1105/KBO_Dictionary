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
    class PlayerInformationDao : IPlayerInformationDao
    {
        private readonly KboDbContext _dbContext = new();

        public void Insert(PlayerInformationEntity entity)
        {
            _dbContext.PlayerInformation?.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(PlayerInformationEntity entity)
        {
            _dbContext.PlayerInformation?.Where(a => a.Id == entity.Id).ExecuteUpdate(setters =>
                setters.SetProperty(a => a.BirthDate, entity.BirthDate).SetProperty(a => a.Height, entity.Height)
                    .SetProperty(a => a.Weight, entity.Weight).SetProperty(a => a.Name, entity.Name));
        }

        public void Delete(PlayerInformationEntity entity)
        {
            _dbContext.PlayerInformation?.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}

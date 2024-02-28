using KBO_Dictionary.BusinessLogicLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.EntityLayer;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Media.Imaging;

namespace KBO_Dictionary.DataAccessLayer
{
    public class PlayerStatRepository : IPlayerStatRepository
    {
        public readonly KboDbContext _dbContext = new();

        public List<PlayerModel> SelectAllPlayerModels()
        {
            if (_dbContext is not { PlayerInformation: not null, StatInformation: not null })
                return new List<PlayerModel>();
            {
                var playerInformationList = _dbContext.PlayerInformation.Include(a => a.TeamInformation)
                    .Join(_dbContext.StatInformation, playerInformation => playerInformation.Id,
                        statInformation => statInformation.Id,
                        (a, b) => new { playerInformation = a, statInformation = b }).ToList();

                return playerInformationList.Select(a => ToPlayerModel(a.playerInformation, a.statInformation))
                    .ToList();
            }
        }

        public PlayerModel ToPlayerModel(PlayerInformationEntity playerInformation,
            StatInformationEntity statInformation)
        {
            return new PlayerModel
            {
                Id = playerInformation.Id,
                Name = playerInformation.Name,
                Team = playerInformation.TeamInformation?.Name ?? string.Empty,
                TeamImage =
                    TeamImageCacheService.Instance().GetBitmapImages()
                        .Find(a => a.Id == playerInformation.TeamInformation.Id).Image,
                Height = playerInformation.Height,
                Weight = playerInformation.Weight,
                BirthDate = playerInformation.BirthDate,
                경기수 = statInformation.Games,
                타석 = statInformation.AtBat,
                타율 = statInformation.Average,
                안타 = statInformation.Hit,
                이루타 = statInformation.DoubleHit,
                삼루타 = statInformation.TripleHit,
                홈런 = statInformation.HomeRun,
                득점 = statInformation.Run,
                타점 = statInformation.RunsBattedIn,
                장타율 = statInformation.SluggingPercentage,
                출루율 = statInformation.OnBasePercentage,
                Ops = statInformation.OnBasePlusSlugging
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.BusinessLogicLayer;
using KBO_Dictionary.DataAccessLayer;

namespace KBO_Dictionary.PresentationLayer
{
    public class CardViewModel
    {
        public CardViewModel()
        {
            var playerStatRepository = new PlayerStatRepository();
            var list = playerStatRepository.SelectAllPlayerModels();
        }

        public PlayerModel PlayerModel { get; set; }
    }
}


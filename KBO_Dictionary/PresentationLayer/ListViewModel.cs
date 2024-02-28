using KBO_Dictionary.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using KBO_Dictionary.BusinessLogicLayer;

namespace KBO_Dictionary.PresentationLayer
{
    public class ListViewModel
    {
        private PlayerStatRepository playerStatRepository = new();

        public ListViewModel()
        {
            PlayerModels = playerStatRepository.SelectAllPlayerModels();
            Cards = PlayerModels.Select(a => new CardViewModel(a)).ToList();
            CardViews = PlayerModels.Select(a => new CardView(){DataContext = new CardViewModel(a)}).ToList();
        }

        public List<PlayerModel> PlayerModels { get; set; }
        public List<CardViewModel> Cards { get; set; }

        public List<CardView> CardViews { get; set; }
    }
}
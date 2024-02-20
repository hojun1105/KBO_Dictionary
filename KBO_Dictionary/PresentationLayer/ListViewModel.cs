using KBO_Dictionary.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.BusinessLogicLayer;

namespace KBO_Dictionary.PresentationLayer
{
    public class ListViewModel
    {
        public ListViewModel()
        {
            var s = new CardViewModel();
        }

        public List<PlayerModel> PlayerModels { get; set; }
        public List<CardViewModel> Cards { get; set; }
    }
}
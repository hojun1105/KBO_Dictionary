using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Documents;
using KBO_Dictionary.DataAccessLayer;

namespace KBO_Dictionary.BusinessLogicLayer;

public interface IPlayerStatRepository
{
    public List<PlayerModel> SelectAllPlayerModels();
}

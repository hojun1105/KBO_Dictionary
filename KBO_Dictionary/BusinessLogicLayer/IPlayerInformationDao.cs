using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.EntityLayer;

namespace KBO_Dictionary.BusinessLogicLayer
{
    public interface IPlayerInformationDao
    {
        void Insert(PlayerInformationEntity entity);
        void Update(PlayerInformationEntity entity);
        void Delete(PlayerInformationEntity entity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KBO_Dictionary.EntityLayer;

namespace KBO_Dictionary.BusinessLogicLayer
{
    public interface ITeamInformationDao
    {
        void Insert(TeamInformationEntity entity);
        void Update(TeamInformationEntity entity);
        void Delete(TeamInformationEntity entity);
    }
}

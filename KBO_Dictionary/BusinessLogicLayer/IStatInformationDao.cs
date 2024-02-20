using KBO_Dictionary.EntityLayer;

namespace KBO_Dictionary.BusinessLogicLayer;

public interface IStatInformationDao
{
    void Insert(StatInformationEntity entity);
    void Update(StatInformationEntity entity);
    void Delete(StatInformationEntity entity);
}
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.Core.Interfaces
{
    public interface IPersonRepository : IBaseRepository<PersonEntity>
    {
        PersonEntity GetPersonEntityById(string query, int id);
    }
}

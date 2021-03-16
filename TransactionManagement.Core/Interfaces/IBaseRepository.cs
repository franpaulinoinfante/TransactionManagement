using System.Collections.Generic;

namespace TransactionManagement.Core.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        int Create(TEntity entity, string query);

        bool Remove(int id, string query);

        bool Update(TEntity entity, string query);

        IEnumerable<TEntity> GetEntities(string query);

        TEntity GetEntityById(int id, string query);
    }
}

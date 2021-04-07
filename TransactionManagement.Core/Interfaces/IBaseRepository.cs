using System.Collections.Generic;

namespace TransactionManagement.Core.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        int Create(TEntity entity, string script);

        bool Remove(int id, string script);

        bool Update(TEntity entity, string script);

        IEnumerable<TEntity> GetEntities(string script);

        TEntity GetEntityById(int id, string script);
    }
}

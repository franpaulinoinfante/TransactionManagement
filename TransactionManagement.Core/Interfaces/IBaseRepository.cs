using System.Collections.Generic;

namespace TransactionManagement.Core.Interfaces
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        void Create(Entity entity, string query);

        void Update(Entity entity, string query);

        void Delete(int id, string query);

        IEnumerable<Entity> GetEntities(string query);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.Infrastructure.Repositories
{
    public class UserRepository : MasterRepository, IUserRepository
    {
        public int Create(PersonEntity entity, string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonEntity> GetEntities(string query)
        {
            throw new NotImplementedException();
        }

        public PersonEntity GetEntityById(int id, string query)
        {
            throw new NotImplementedException();
        }

        public PersonEntity GetPersonEntityById(string query, int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id, string query)
        {
            throw new NotImplementedException();
        }

        public bool Update(PersonEntity entity, string query)
        {
            throw new NotImplementedException();
        }
    }
}

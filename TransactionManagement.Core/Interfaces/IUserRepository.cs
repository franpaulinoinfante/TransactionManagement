using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities;

namespace TransactionManagement.Core.Interfaces
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        UserEntity GetUserEntityByUserName(string script, string userName);
    }
}

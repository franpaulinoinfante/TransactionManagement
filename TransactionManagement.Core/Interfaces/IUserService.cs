using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Interfaces
{
    public interface IUserService
    {
        void SetDocumentType( IEnumerable<Entities.UserEntity> userEntities, IEnumerable<Entities.DocumentTypeEntity> documentTypeEntities);
    }
}

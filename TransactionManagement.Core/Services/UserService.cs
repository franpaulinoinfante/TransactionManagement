using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.Core.Services
{
    public class UserService : IUserService
    {
        public void SetDocumentType(IEnumerable<UserEntity> userEntities, IEnumerable<DocumentTypeEntity> documentTypeEntities)
        {
            foreach (UserEntity userEntity in userEntities)
            {
                foreach (DocumentTypeEntity documentTypeEntity in documentTypeEntities)
                {
                    userEntity.SetDocumentType(documentTypeEntity);
                }
            }
        }
    }
}

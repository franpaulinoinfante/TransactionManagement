using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.User
{
    public class UserManagementService : PersonManagementService, IUserManagementService
    {
        private readonly IDocumentTypeManagementService _documentTypeManagementService;

        public UserManagementService(IUserRepository userRepository, IDocumentTypeManagementService documentTypeManagementService) : base(userRepository, documentTypeManagementService)
        {
            _documentTypeManagementService = documentTypeManagementService;
        }
    }
}

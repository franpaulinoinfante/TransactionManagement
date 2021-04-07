using System.Collections.Generic;
using TransactionManagement.ApplicationService.Enums;

namespace TransactionManagement.ApplicationService.ManagementServices.UserManagementServices
{
    public interface IUserManagementService
    {
        bool CreateUser(UserDto userDto, EntityState entityState);

        bool RemoveUser(int id, EntityState entityState);

        bool UpdateUser(UserDto userDto, EntityState entityState);

        IEnumerable<UserDto> GetUserDtos();

        UserDto GetUserDtoById(int id, EntityState entityState);

        IEnumerable<Core.Entities.BankAggregate.BankAccountEntity> GetBankAccounts();

        bool SetUserAccount(UserDto userDto, string userName, string password);

        IEnumerable<DocumentTypeManagementService.DocumentTypeDto> GetDocumentTypeDtos();
    }
}

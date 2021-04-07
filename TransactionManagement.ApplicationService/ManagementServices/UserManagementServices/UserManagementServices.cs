using System;
using System.Collections.Generic;
using TransactionManagement.ApplicationService.Enums;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.Core.Entities;
using TransactionManagement.Core.Entities.BankAggregate;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Core.Queries;

namespace TransactionManagement.ApplicationService.ManagementServices.UserManagementServices
{
    public class UserManagementServices : IUserManagementService
    {
        private readonly IUserRepository _userRepository;
        private readonly IDocumentTypeManagementService _documentManagementService;
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly IUserService _userService;
        private readonly UserMap _map;
        private readonly DocumentTypeMap _dtmap;

        public UserManagementServices(IUserRepository userRepository, IDocumentTypeManagementService documentManagementService, IUserService userService, IDocumentTypeRepository documentTypeRepository)
        {
            _userRepository = userRepository;
            _documentManagementService = documentManagementService;
            _documentTypeRepository = documentTypeRepository;
            _userService = userService;
            _map = new UserMap();
            _dtmap = new DocumentTypeMap();
        }

        public bool CreateUser(UserDto userDto, EntityState entityState)
        {
            UserEntity entity = _map.FromUserDtoToUserEntity(userDto);

            int newId = _userRepository.Create(entity, UserQueries.CreateUser);
            if (newId > 0)
            {
                return true;
            }
            throw new Exception();
        }

        public bool RemoveUser(int id, EntityState entityState)
        {
            UserEntity entity = _userRepository.GetEntityById(id, UserQueries.GetUserById);
            if (entity != null)
            {
                return _userRepository.Remove(id, UserQueries.RemoveUser);
            }
            throw new Exception();
        }

        public bool UpdateUser(UserDto userDto, EntityState entityState)
        {
            UserEntity entity = _userRepository.GetEntityById(userDto.Id, UserQueries.GetUserById);
            if (entity != null)
            {
                entity.UpdateUser(userDto.UserName, userDto.Password, userDto.FirstName, userDto.LastName, userDto.Gender, userDto.DocumentTypeId, userDto.DocumentCode, userDto.Phone, userDto.City, userDto.Address);

                return _userRepository.Update(entity, UserQueries.UpdateUser);
            }
            throw new Exception();
        }

        public IEnumerable<DocumentTypeDto> GetDocumentTypeDtos()
        {
            return _documentManagementService.GetDocumentTypeDtos();
        }

        public IEnumerable<UserDto> GetUserDtos()
        {
            IEnumerable<UserEntity> userEntities = _userRepository.GetEntities(UserQueries.GetUsers);
            IEnumerable<DocumentTypeEntity> documentTypeEntities = _documentTypeRepository.GetEntities(DocumentTypeQueries.GetDocumentTypes);

            _userService.SetDocumentType(userEntities, documentTypeEntities);

            return _map.FromUserEntitiesToUserDtos(userEntities);
        }

        public UserDto GetUserDtoById(int id, EntityState entityState)
        {
            UserEntity userEntity = _userRepository.GetEntityById(id, UserQueries.GetUserById);
            if (userEntity != null)
            {
                return _map.FromUserEntityToUserDto(userEntity);
            }
            throw new Exception();
        }

        public IEnumerable<BankAccountEntity> GetBankAccounts()
        {
            throw new NotImplementedException();
        }

        public bool SetUserAccount(UserDto userDto, string userName, string password)
        {
            UserEntity userEntity = _userRepository.GetEntityById(userDto.Id, UserQueries.GetUserById);
            if (userEntity != null)
            {
                userEntity.SetUserAccount(userName, password);
                return _userRepository.Update(userEntity, UserQueries.UpdateUser);
            }
            throw new Exception();
        }
    }
}

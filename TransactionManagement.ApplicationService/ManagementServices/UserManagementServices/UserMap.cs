using System.Collections.Generic;
using System.Linq;
using TransactionManagement.Core.Entities;

namespace TransactionManagement.ApplicationService.ManagementServices.UserManagementServices
{
    internal class UserMap
    {
        internal UserDto FromUserEntityToUserDto(UserEntity userEntity)
        {
            return new UserDto
            {
                Id = userEntity.Id,
                UserName = userEntity.UserName,
                Password = userEntity.Password,
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                Gender = userEntity.Gender,
                DocumentTypeId = userEntity.DocumentTypeId,
                DocumentCode = userEntity.DocumentCode,
                Phone = userEntity.Phone,
                City = userEntity.City,
                Address = userEntity.Address
            };
        }

        internal IEnumerable<UserDto> FromUserEntitiesToUserDtos(IEnumerable<UserEntity> userEntities)
        {
            //List<UserDto> userDtos = new List<UserDto>();

            //foreach (UserEntity userEntity in userEntities)
            //{
            //    userDtos.Add(new UserDto
            //    {
            //        Id = userEntity.Id,
            //        UserName = userEntity.UserName,
            //        Password = userEntity.Password,
            //        FirstName = userEntity.FirstName,
            //        LastName = userEntity.LastName,
            //        Gender = userEntity.Gender,
            //        DocumentTypeId = userEntity.DocumentTypeId,
            //        DocumentCode = userEntity.DocumentCode,
            //        Phone = userEntity.Phone,
            //        City = userEntity.City,
            //        Address = userEntity.Address
            //    });
            //}

            List<UserDto> userDtos = (
                from userEntity in userEntities
                select new UserDto
                {
                    Id = userEntity.Id,
                    UserName = userEntity.UserName,
                    Password = userEntity.Password,
                    FirstName = userEntity.FirstName,
                    LastName = userEntity.LastName,
                    Gender = userEntity.Gender,
                    DocumentTypeId = userEntity.DocumentType.Id,
                    DocumentCode = userEntity.DocumentCode,
                    Phone = userEntity.Phone,
                    City = userEntity.City,
                    Address = userEntity.Address,
                    DocumentType = userEntity.DocumentType.DocumentType,
                    Description = userEntity.DocumentType.Description
                }).ToList();

            return userDtos;
        }

        internal UserEntity FromUserDtoToUserEntity(UserDto userDto)
        {
            return new UserEntity(
                userDto.Id,
                userDto.UserName,
                userDto.Password,
                userDto.FirstName,
                userDto.LastName,
                userDto.Gender,
                userDto.DocumentTypeId,
                userDto.DocumentCode,
                userDto.Phone,
                userDto.City,
                userDto.Address);
        }
    }
}

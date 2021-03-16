using System.Collections.Generic;
using TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.Icumbent;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    internal class PersonMap
    {
        internal IEnumerable<PersonDto> FromPersonEntityToPersonDto(IEnumerable<PersonEntity> personEntities)
        {
            List<PersonDto> personDtos = new List<PersonDto>();

            foreach (PersonEntity entity in personEntities)
            {
                personDtos.Add(new PersonDto
                {
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Gender = entity.Gender,
                    DocumentTypeId = entity.DocumentTypeId,
                    DocumentCode = entity.DocumentCode,
                    Phone = entity.Phone,
                    City = entity.City,
                    Address = entity.Address
                });
            }

            return personDtos;
        }

        internal PersonEntity FromPersonDtoToPersonEntity(PersonDto dto)
        {
            return new PersonEntity(dto.Id, dto.FirstName, dto.LastName, dto.Gender, dto.Phone, dto.City, dto.Address, dto.DocumentTypeId, dto.DocumentCode);
        }

        //internal IEnumerable<PersonDto> FromPersonEntityToPersonDto(IEnumerable<PersonEntity> personEntities)
        //{
        //    List<PersonDto> personDtos = new List<PersonDto>();

        //    foreach (PersonEntity entity in personEntities)
        //    {
        //        personDtos.Add(new PersonDto
        //        {
        //            Id = entity.Id,
        //            FirstName = entity.FirstName,
        //            LastName = entity.LastName,
        //            Gender = entity.Gender,
        //            DocumentTypeId = entity.DocumentTypeId,
        //            DocumentCode = entity.DocumentCode,
        //            Phone = entity.Phone,
        //            City = entity.City,
        //            Address = entity.Address
        //        });
        //    }

        //    return personDtos;
        //}

       
    }
}

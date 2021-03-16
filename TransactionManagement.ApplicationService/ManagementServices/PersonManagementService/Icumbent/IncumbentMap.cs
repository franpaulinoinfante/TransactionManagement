using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.Icumbent
{
    class IncumbentMap
    {
        internal PersonEntity FromIncumbentDtoToPersonEntity(IncumbentDto dto)
        {
            return new PersonEntity(dto.Id, dto.FirstName, dto.LastName, dto.Gender, dto.Phone, dto.City, dto.Address, dto.DocumentTypeId, dto.DocumentCode);
        }

        internal IEnumerable<IncumbentDto> FromIncumbentEntityToIncumbentDto(IEnumerable<IncumbentEntity> incumbentEntities)
        {
            var incumbentDtos = new List<IncumbentDto>();

            foreach (var incumbent in incumbentEntities)
            {
                var dto = new IncumbentDto
                {
                    Id = incumbent.Id,
                    FirstName = incumbent.FirstName,
                    LastName = incumbent.LastName,
                    Gender = incumbent.Gender,
                    Phone = incumbent.Phone,
                    City = incumbent.City,
                    Address = incumbent.Address,
                    DocumentTypeId = incumbent.DocumentTypeId,
                    DocumentCode = incumbent.DocumentCode,
                    IncumbentType = incumbent.IncumbentType
                };
                incumbentDtos.Add(dto);
            }

            return incumbentDtos;
        }
    }
}

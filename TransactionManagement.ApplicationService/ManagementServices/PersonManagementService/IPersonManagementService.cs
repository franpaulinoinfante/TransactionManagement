using System.Collections.Generic;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public interface IPersonManagementService
    {
        int CreatePerson(PersonEntity entity);

        bool RemovePerson(int id);

        bool UpdatePerson(PersonEntity entity);

        IEnumerable<PersonDto> GetPersonDtos();

        IEnumerable<DocumentTypeDto> GetDocumentTypeDtos();

        PersonDto GetPersonById(int id);
    }
}

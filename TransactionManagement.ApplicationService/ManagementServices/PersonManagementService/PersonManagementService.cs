using System.Collections.Generic;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.Core.Entities;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Core.Queries;
using TransactionManagement.Infrastructure.Repositories;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public abstract class PersonManagementService : IPersonManagementService
    {
        protected readonly IPersonRepository _personRepository;
        private readonly IDocumentTypeManagementService _documentTypeManagementService;
        private readonly PersonMap _map;

        public PersonManagementService(IPersonRepository personRepository, IDocumentTypeManagementService documentTypeManagementService)
        {
            _personRepository = personRepository;
            _map = new PersonMap();
            _documentTypeManagementService = documentTypeManagementService;
        }

        public IEnumerable<PersonEntity> GetPersonEntities()
        {
            string query = PersonQueries.GetPeople;

            return _personRepository.GetEntities(query);

            //return peopleEntities;
        }

        public IEnumerable<DocumentTypeDto> GetDocumentTypeDtos()
        {
            return _documentTypeManagementService.GetDocumentTypeDtos();
        }

        public int CreatePerson(PersonEntity entity)
        {
            string query = PersonQueries.CreatePerson;

            return _personRepository.Create(entity, query);
        }

        public bool RemovePerson(int id)
        {
            string query = PersonQueries.RemovePerson;

            return _personRepository.Remove(id, query);
        }

        public bool UpdatePerson(PersonEntity entity)
        {
            PersonEntity personEntity = GetPersonById(entity.Id);

            if (personEntity == null)
            {
                string personNotFound = "Person Not Found";
                return false;
            }

            personEntity.UpdatePerson(entity.FirstName, entity.LastName, entity.Gender, entity.Phone, entity.City, entity.Address, entity.DocumentTypeId, entity.DocumentCode);

            string query = PersonQueries.UpdatePerson;

            return _personRepository.Update(entity, query);
        }

        public PersonEntity GetPersonById(int id)
        {
            string query = PersonQueries.GetPersonById;

            return _personRepository.GetPersonEntityById(query,id);
        }
    }
}

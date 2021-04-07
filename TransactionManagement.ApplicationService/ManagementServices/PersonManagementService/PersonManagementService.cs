using System;
using System.Collections.Generic;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Core.Queries;

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

        public IEnumerable<PersonDto> GetPersonDtos()
        {
            string query = PersonQueries.GetPeople;
            var personEntity = _personRepository.GetEntities(query);

            return _map.FromPersonEntityToPersonDto(personEntity);            
        }

        public IEnumerable<PersonEntity> GetPersonEntities()
        {
            return _personRepository.GetEntities(PersonQueries.GetPeople);
        }

        public IEnumerable<DocumentTypeDto> GetDocumentTypeDtos()
        {
            return _documentTypeManagementService.GetDocumentTypeDtos();
        }

        public int CreatePerson(PersonEntity entity)
        {
            string query = PersonQueries.CreatePerson;
            int personEntityId = _personRepository.Create(entity, query);

            if (personEntityId == 0)
            {
                throw new Exception("No se pudo crear esta persona");
            }

            return personEntityId;
        }

        public bool RemovePerson(int id)
        {
            string query = PersonQueries.GetPersonById;
            PersonEntity person = _personRepository.GetEntityById(id, query);

            if (person != null)
            {
                query = PersonQueries.RemovePerson;
                return _personRepository.Remove(id, query);
            }

            return false;
        }

        public bool UpdatePerson(PersonEntity entity)
        {
            string query = PersonQueries.GetPersonById;
            PersonEntity personEntity = _personRepository.GetEntityById(entity.Id, query);

            if (personEntity != null)
            {
                personEntity.UpdatePerson(entity.FirstName, entity.LastName, entity.Gender, entity.Phone, entity.City, entity.Address, entity.DocumentTypeId, entity.DocumentCode);

                query = PersonQueries.UpdatePerson;
                return _personRepository.Update(personEntity, query);
            }

            return false;
        }

        public PersonDto GetPersonById(int id)
        {
            string query = PersonQueries.GetPersonById;
            PersonEntity person = _personRepository.GetEntityById(id, query);

            if (person == null)
            {
                throw new Exception($"No se encontro esta persona");
            }

            return _map.FromPersonEntityToPersonDto(person);
        }
    }
}

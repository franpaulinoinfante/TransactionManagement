using System;
using System.Collections.Generic;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Core.Queries;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.Icumbent
{
    public class IncumbentManagementService : PersonManagementService, IIncumbentManagementService
    {
        private readonly IIncumbentRepository _incumbentRepository;
        private readonly IDocumentTypeManagementService _documentTypeManagementService;

        private readonly IncumbentMap _map;

        public IncumbentManagementService(IPersonRepository personRepository, IIncumbentRepository incumbentRepository, IDocumentTypeManagementService documentTypeManagementService)
            : base(personRepository, documentTypeManagementService)
        {
            _incumbentRepository = incumbentRepository;

            _map = new IncumbentMap();
            _documentTypeManagementService = documentTypeManagementService;
        }

        public int CreateIncumbent(IncumbentDto incumbentDto)
        {
            PersonEntity personEntity = _map.FromIncumbentDtoToPersonEntity(incumbentDto);

            int newId = CreatePerson(personEntity);

            IncumbentEntity entity = new IncumbentEntity(newId, incumbentDto.IncumbentType);

            string query = IncumbentQueries.CreateIncumbent;

            return _incumbentRepository.Create(entity, query);
        }

        public bool UpdateIncumbent(IncumbentDto incumbentDto)
        {
            PersonEntity personEntity = _map.FromIncumbentDtoToPersonEntity(incumbentDto);

            bool success = UpdatePerson(personEntity);

            if (!success)
            {
                return false;
            }

            IncumbentEntity entity = GetIncumbentEntityById(personEntity.Id);

            entity.UpdateIncumbent(incumbentDto.IncumbentType);

            //string query = IncumbentQueries.UpdateIncumbent;

            bool incumbentSuccess = _incumbentRepository.Update(entity, IncumbentQueries.UpdateIncumbent);

            if (!incumbentSuccess)
            {
                return false;
            }

            return true;
        }

        public bool RemoveInumbent(int id)
        {
            PersonEntity personEn = GetPersonById(id);

            if (personEn != null)
            {
                throw new Exception($"No se encontro este incumbent, { nameof(id) }");
            }

            string query = PersonQueries.UpdatePerson;

            return _personRepository.Update(personEn, query);
        }

        public IEnumerable<IncumbentDto> GetIncumbentEntities()
        {
            IEnumerable<IncumbentEntity> incumbentEntities = _incumbentRepository.GetEntities(IncumbentQueries.GetIncumbentEntities);

            var incumbentDto = _map.FromIncumbentEntityToIncumbentDto(incumbentEntities);
            return incumbentDto;
        }

        public IncumbentEntity GetIncumbentEntityById(int id)
        {
            return null;
        }
    }
}

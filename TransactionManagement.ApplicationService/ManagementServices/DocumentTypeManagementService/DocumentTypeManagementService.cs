using System;
using System.Collections.Generic;
using TransactionManagement.ApplicationService.Enums;
using TransactionManagement.Core.Entities;
using TransactionManagement.Core.Exceptions;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Core.Queries;

namespace TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService
{
    public class DocumentTypeManagementService : IDocumentTypeManagementService
    {
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly DocumentTypeMap _map;

        public DocumentTypeManagementService(IDocumentTypeRepository documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
            _map = new DocumentTypeMap();
        }

        #region COmprobar
        public string SaveChanges(DocumentTypeDto documentTypeDto, EntityState state)
        {
            string message = string.Empty;

            switch (state)
            {
                case EntityState.Created:
                    //if (CreateDocumentType(documentTypeDto))
                    //{
                    //    //int newId = _documentTypeRepository.Create(documentTypeEntity, query);
                    //    message = "El nuevo tipo de documento se ha creado";
                    //}
                    break;
                case EntityState.Updated:
                    message = "El tipo de documento se ha actualizado";
                    break;
                case EntityState.Remove:
                    message = "El tipo de documento se ha eliminado";
                    break;
                default:
                    message = "Operación no valida";
                    break;
            }

            return message;
        }

        public bool CreateDocumentTypse(DocumentTypeDto documentTypeDto)
        {
            if (documentTypeDto == null)
            {
                throw new NullReferenceException(nameof(documentTypeDto));
            }

            string query = DocumentTypeQueries.GetDocumentTypeByDocumentType;
            DocumentTypeEntity documentTypeEntity = _documentTypeRepository.GetEntityById(documentTypeDto.Id, query);

            if (documentTypeEntity != null)
            {
                throw new NullReferenceException("EL tipo de documento esta creado");
            }

            documentTypeEntity = _map.FromDocumentTypeDtoToDocumentTypeEntity(documentTypeDto);

            query = DocumentTypeQueries.CreateDocumentType;
            int newId = _documentTypeRepository.Create(documentTypeEntity, query);

            return false;
        }
        #endregion

        public int CreateDocumentType(DocumentTypeDto documentTypeDto)
        {
            if (documentTypeDto == null)
            {
                throw new NullReferenceException(nameof(documentTypeDto));
            }

            DocumentTypeEntity documentTypeEntity = _map.FromDocumentTypeDtoToDocumentTypeEntity(documentTypeDto);

            string query = DocumentTypeQueries.CreateDocumentType;
            int newId = _documentTypeRepository.Create(documentTypeEntity, query);

            return newId;
        }

        public bool RemoveDocumentType(DocumentTypeDto documentTypeDto)
        {
            string query = DocumentTypeQueries.GetDocumentTypeByDocumentType;
            DocumentTypeEntity documentTypeEntity = _documentTypeRepository.GetEntityById(documentTypeDto.Id, query);

            if (documentTypeEntity == null)
            {
                throw new NullReferenceException($"Este tipo de documento no existe");
            }

            query = DocumentTypeQueries.RemoveDocumentType;

            bool success = _documentTypeRepository.Remove(documentTypeEntity.Id, query);

            return success;
        }

        public bool UpdateDocumentType(DocumentTypeDto documentTypeDto)
        {
            if (documentTypeDto == null)
            {
                return false;
            }

            string query = DocumentTypeQueries.GetDocumentTypeByDocumentType;
            DocumentTypeEntity documentTypeEntity = _documentTypeRepository.GetEntityById(documentTypeDto.Id, query);

            bool success = false;
            if (documentTypeEntity != null)
            {
                documentTypeEntity.UpdateDocument(documentTypeDto.DocumentType, documentTypeDto.Description);

                query = DocumentTypeQueries.UpdateDocumentType;
                success = _documentTypeRepository.Update(documentTypeEntity, query);
            }

            return success;
        }

        public DocumentTypeDto GetDocumentTypeById(int id)
        {
            string query = DocumentTypeQueries.GetDocumentTypeByDocumentType;
            DocumentTypeEntity documentTypeEntity = _documentTypeRepository.GetEntityById(id, query);

            if (documentTypeEntity == null)
            {
                throw new NotFoundDocumentTypeException(new KeyNotFoundException(nameof(id)));
            }

            return _map.FromDocumentTypeEntityToDocumentTypeDto(documentTypeEntity);
        }

        public IEnumerable<DocumentTypeDto> GetDocumentTypeDtos()
        {
            string query = DocumentTypeQueries.GetDocumentTypes;
            IEnumerable<DocumentTypeEntity> documentTypeEntities = _documentTypeRepository.GetEntities(query);

            if (documentTypeEntities == null)
            {
                throw new NullReferenceException();
            }

            return _map.FromDocumentTypeEntitiesToDocumentTypeDtos(documentTypeEntities);
        }
    }
}

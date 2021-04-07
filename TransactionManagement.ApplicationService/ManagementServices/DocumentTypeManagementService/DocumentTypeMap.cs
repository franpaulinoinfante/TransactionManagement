using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities;

namespace TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService
{
    class DocumentTypeMap
    {
        internal DocumentTypeEntity FromDocumentTypeDtoToDocumentTypeEntity(DocumentTypeDto documentTypeDto)
        {
            return new DocumentTypeEntity(documentTypeDto.Id, documentTypeDto.DocumentType, documentTypeDto.Description);
        }

        internal DocumentTypeDto FromDocumentTypeEntityToDocumentTypeDto(DocumentTypeEntity documentTypeEntity)
        {
            return new DocumentTypeDto
            {
                Id = documentTypeEntity.Id,
                DocumentType = documentTypeEntity.DocumentType,
                Description = documentTypeEntity.Description
            };
        }

        internal List<DocumentTypeDto> FromDocumentTypeEntitiesToDocumentTypeDtos(IEnumerable<DocumentTypeEntity> documentTypeEntities)
        {
            List<DocumentTypeDto> documentTypeDtos = new List<DocumentTypeDto>();

            foreach (var documentTypeDto in documentTypeEntities)
            {
                documentTypeDtos.Add(new DocumentTypeDto
                {
                    Id = documentTypeDto.Id,
                    DocumentType = documentTypeDto.DocumentType,
                    Description = documentTypeDto.Description
                });
            }

            return documentTypeDtos;
        }

        internal IEnumerable<DocumentTypeEntity> FromDocumentTypeDtoToDocumentTypeEntities(IEnumerable<DocumentTypeDto> documentTypeDtos)
        {
            List<DocumentTypeEntity> documentTypeEntities = new List<DocumentTypeEntity>();

            foreach (var documentTypeDto in documentTypeDtos)
            {
                documentTypeEntities.Add(new DocumentTypeEntity
                (
                    documentTypeDto.Id,
                    documentTypeDto.DocumentType,
                    documentTypeDto.Description
                ));
            }

            return documentTypeEntities;
        }
    }
}

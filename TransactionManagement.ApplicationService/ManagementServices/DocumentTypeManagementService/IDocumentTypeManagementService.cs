using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService
{
    public interface IDocumentTypeManagementService
    {
        int CreateDocumentType(DocumentTypeDto documentTypeDto);

        bool RemoveDocumentType(DocumentTypeDto documentTypeDto);

        bool UpdateDocumentType(DocumentTypeDto documentTypeDto);

        DocumentTypeDto GetDocumentTypeById(DocumentTypeDto documentTypeDto);

        IEnumerable<DocumentTypeDto> GetDocumentTypeDtos();
    }
}

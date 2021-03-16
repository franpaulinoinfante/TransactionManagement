using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.ApplicationService.ManagementServices.Command;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Core.Queries;

namespace TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService
{
    public class CreateDocumentTypeCommand : ICommand
    {
        private readonly IDocumentTypeRepository _documentTypeRepository;

        public CreateDocumentTypeCommand(IDocumentTypeRepository documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
        }

        public void Excute()
        {
            //var result = _documentTypeRepository.Create(entity, DocumentTypeQueries.CreateDocumentType);
        }
    }
}

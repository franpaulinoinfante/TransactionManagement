using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.WinFormApp.Views;

namespace TransactionManagement.WinFormApp.Controllers
{
    internal class DocumentTypeController
    {
        private readonly IDocumentTypeManagementService _documentTypeManagementService;

        private DocumentTypeView _documentTypeView;

        public DocumentTypeController(IDocumentTypeManagementService documentTypeManagementService, DocumentTypeView documentTypeView)
        {
            _documentTypeManagementService = documentTypeManagementService;
            _documentTypeView = documentTypeView;

            _documentTypeView.Load += new EventHandler(GetDocumentTypes);
            _documentTypeView.btnFindBy.Click += new EventHandler(GetDocumentTypeByDescription);
        }

        private void GetDocumentTypes(object sender, EventArgs e)
        {
            var documentTypes = _documentTypeManagementService.GetDocumentTypeDtos();

            AddColumnsToGridView();

            foreach (var documentType in documentTypes)
            {
                _documentTypeView.dgvDocumentType.Rows.Add(documentType.Id, documentType.DocumentType, documentType.Description);
            }            
        }

        private void GetDocumentTypeByDescription(object sender, EventArgs a)
        {
            AddColumnsToGridView();

            var documentType = _documentTypeManagementService.GetDocumentTypeById(new DocumentTypeDto());

            _documentTypeView.dgvDocumentType.Rows.Add(documentType.Id, documentType.DocumentType, documentType.Description);
        }

        private void AddColumnsToGridView()
        {
            _documentTypeView.dgvDocumentType.Columns.Clear();
            _documentTypeView.dgvDocumentType.Columns.Add("IdDgv", "Id");
            _documentTypeView.dgvDocumentType.Columns.Add("DocumentTypeDgv", "Tipo de Documento");
            _documentTypeView.dgvDocumentType.Columns.Add("DescriptionDgv", "Descripción");
        }
    }
}

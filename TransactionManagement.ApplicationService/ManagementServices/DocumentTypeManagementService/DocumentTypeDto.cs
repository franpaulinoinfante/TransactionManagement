using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService
{
    public class DocumentTypeDto
    {
        public int Id { get; set; }

        public string DocumentType { get; set; }

        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;

namespace TransactionManagement.ApplicationService.ManagementServices.Command
{
    public class Invoke
    {
        private readonly ICommand[] _commands = new ICommand[4];

        public Invoke(IDocumentTypeManagementService documentTypeManagementService)
        {
            //_commands[0] = new CreateDocumentTypeCommand();
        }
    }
}

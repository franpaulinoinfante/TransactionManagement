using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public interface ICommand
    {
        void Execute();
    }
}

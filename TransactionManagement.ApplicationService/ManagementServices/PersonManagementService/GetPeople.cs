using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public class GetPeople
    {
        private readonly IPersonManagementService _personManagementService;

        public GetPeople(IPersonManagementService personManagementService)
        {
            _personManagementService = personManagementService;
        }

        public void Execute()
        {
            _personManagementService.GetPersonEntities();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.Icumbent
{
    public interface IIncumbentManagementService : IPersonManagementService
    {
        int CreateIncumbent(IncumbentDto incumbentDto);

        IEnumerable<IncumbentDto> GetIncumbentEntities();
    }
}

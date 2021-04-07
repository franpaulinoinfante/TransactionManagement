using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Exceptions.BankExceptions
{
    public class NotFoundBankAccountException:Exception
    {
        public NotFoundBankAccountException(string name, Exception innerException) : base(name, innerException)
        {

        }
    }
}

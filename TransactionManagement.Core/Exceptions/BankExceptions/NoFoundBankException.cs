using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Exceptions.BankExceptions
{
    public class NoFoundBankException:Exception
    {
        public NoFoundBankException(string bankName, Exception innerException) :base($"Este banco { bankName } no existe ",innerException)
        {

        }
    }
}

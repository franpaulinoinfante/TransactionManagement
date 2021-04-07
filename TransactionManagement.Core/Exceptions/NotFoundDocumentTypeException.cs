using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Exceptions
{
    public class NotFoundDocumentTypeException :Exception
    {
        public NotFoundDocumentTypeException(Exception innerException) :base("No se encontro este documento", innerException)
        {
            
        }
    }
}

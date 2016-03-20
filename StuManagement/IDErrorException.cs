using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StuManagement
{
    class IDErrorException:ApplicationException
    {
         public IDErrorException(string message):base(message)
        {
            
        }
         public IDErrorException(string message, Exception innerException)
            : base(message,innerException)
        {

        }
    }
}

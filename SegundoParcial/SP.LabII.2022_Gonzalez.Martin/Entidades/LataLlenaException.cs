using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public class LataLlenaException : Exception
    {
        public LataLlenaException()
        {
        }

        public LataLlenaException(string message) : base(message)
        {
        }

        public LataLlenaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

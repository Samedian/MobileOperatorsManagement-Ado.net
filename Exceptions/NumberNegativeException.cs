using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// This exception is for negative input
    /// </summary>
    public class NumberNegativeException : Exception
    {
        public NumberNegativeException(string msg) : base(msg)
        {

        }
    }
}

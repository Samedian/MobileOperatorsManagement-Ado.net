using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// This is user defined exception for string contain 
    /// digits
    /// </summary>
    public class StringContainDigit : Exception
    {
        public StringContainDigit(string msg) : base(msg)
        {

        }
    }
}

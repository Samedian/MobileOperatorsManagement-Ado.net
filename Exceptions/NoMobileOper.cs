using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NoMobileOper : Exception
    {
        public NoMobileOper(string msg) : base(msg)
        {

        }
    }
}

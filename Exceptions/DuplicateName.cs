using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class DuplicateName : Exception
    {
        public DuplicateName(string msg):base(msg)
        {

        }
    }
}

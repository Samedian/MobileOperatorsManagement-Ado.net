using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class RatingExceed : Exception
    {
        public RatingExceed(string msg):base(msg)
        {

        }
    }
}

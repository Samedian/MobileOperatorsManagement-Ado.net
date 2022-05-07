using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string PersonName,int MobileOperatorId)
        {
            this.PersonName = PersonName;
            this.MobileOperatorId = MobileOperatorId;
        }
        public int PersonId { get; set; }

        public string PersonName { get; set; }

        public int MobileOperatorId { get; set; }


    }
}

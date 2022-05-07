using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    public class MobileOperatorCon
    {
        public MobileOperatorCon()
        {

        }
        public MobileOperatorCon(string Name,double Rating)
        {
            this.Name = Name;
            this.Rating = Rating;
        }
        public int MobileOperatorId { get; set; }

        public string Name { get; set; }

        public double Rating { get; set; }
    }
}

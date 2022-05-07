using MobileOperator;
using System;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BussinessLayer
{
    public class MobileOperBussinessLayer
    {

        public string AddMobileOper(MobileOperatorCon mobileOperator)
        {
            MobileDataAccessLayer mobileDataAccessLayer = new MobileDataAccessLayer();
            string msg = mobileDataAccessLayer.AddToDB(mobileOperator);
            return msg;
        }

        public List<MobileOperatorCon> Display()
        {
            MobileDataAccessLayer mobileDataAccessLayer = new MobileDataAccessLayer();

            List<MobileOperatorCon> list = mobileDataAccessLayer.Display();

            return list;

        }

        public ArrayList Top2()
        {
            MobileDataAccessLayer mobileDataAccessLayer = new MobileDataAccessLayer();

            ArrayList list = mobileDataAccessLayer.Top2();

            return list;

        }
    }
}

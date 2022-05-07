using Exceptions;
using MobileOperator;
using System;
using BussinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment2;
using System.Collections;

namespace CodingChallenge2
{
    class MobileOperatorDetails
    {

        public string AddMobileOper()
        {

            Console.WriteLine("Enter Mobile Operator Name");
            string name = Input.StringInput();

            Console.WriteLine("Enter Rating :");
            double rating = Input.PositiveDouble();

            try
            {
                if (rating > 5)
                    throw new RatingExceed("Rating must be less then 5");
            }catch(Exception exception)
            {
                Console.WriteLine(exception);
            }

            MobileOperatorCon mobileOperator = new MobileOperatorCon(name, rating);

            MobileOperBussinessLayer mobileOperBussinessLayer = new MobileOperBussinessLayer();
            string msg = mobileOperBussinessLayer.AddMobileOper(mobileOperator);

            return msg;
        }
        
        public string Display()
        {


            MobileOperBussinessLayer mobileOperBussinessLayer = new MobileOperBussinessLayer();

            List<MobileOperatorCon> list = mobileOperBussinessLayer.Display();

            try
            {
                if (list.Count == 0)
                    throw new NoMobileOper("No Mobile Operator");
                    
            }catch(Exception ex)
            {
                return "No Mobile Oper\n" + ex;
            }

            foreach (MobileOperatorCon data in list)
            {
                Console.WriteLine("Id       :" + data.MobileOperatorId);

                Console.WriteLine("Operator :"+data.Name);
            }
            return "Successfully Executed";
        }

        public string Top2()
        {

            MobileOperBussinessLayer mobileOperBussinessLayer = new MobileOperBussinessLayer();

            ArrayList list = mobileOperBussinessLayer.Top2();

            try
            {
                if (list.Count != 2)
                    throw new NoMobileOper("No Two Mobile Operator");

            }
            catch (Exception ex)
            {
                return "No Two Mobile Oper\n" + ex;
            }

            foreach (MobileOperatorCon data in list)
            {
                Console.WriteLine("Id       :" + data.MobileOperatorId);

                Console.WriteLine("Operator :" + data.Name);
            }
            return "Successfully Executed";

        }
    }
}

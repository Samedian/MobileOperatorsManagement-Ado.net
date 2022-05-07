using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment2;

namespace CodingChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch;
            string msg;
            int choice;
            do
            {
                Console.WriteLine("1.Add Mobile Operator");
                Console.WriteLine("2.Display All Mobile Operator");
                Console.WriteLine("3.Enter Person Details");
                Console.WriteLine("4.Top 2 Mobile Operator");
                Console.WriteLine("5.Seach Person Details with Mobile Oper using Person Id");
                Console.WriteLine("6.Fetch All Person ");
                choice = Input.PositiveInteger();

                switch(choice)
                {
                    case 1:
                        MobileOperatorDetails mobileOperator = new MobileOperatorDetails();
                        msg = mobileOperator.AddMobileOper();
                        Console.WriteLine(msg);
                        break;

                    case 2:
                        mobileOperator = new MobileOperatorDetails();
                        msg = mobileOperator.Display();
                        Console.WriteLine(msg);
                        break;
                    case 3:
                        PersonDetails personDetails = new PersonDetails();
                        msg = personDetails.AddPerson();
                        Console.WriteLine(msg);
                        break;

                    case 4:
                        mobileOperator = new MobileOperatorDetails();
                        msg = mobileOperator.Top2();
                        Console.WriteLine(msg);
                        break;
                        
                    case 5:
                        personDetails = new PersonDetails();
                        msg = personDetails.SearchById();
                        Console.WriteLine(msg);
                        break;
                    case 6:
                        personDetails = new PersonDetails();
                        msg = personDetails.FetchData();
                        Console.WriteLine(msg);
                        break;

                }

                Console.WriteLine("Do you want to continue ");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment2;
using MobileOperator;
using BussinessLayer;
using Exceptions;
using System.IO;

namespace CodingChallenge2
{
    class PersonDetails
    {
        PersonBussinessLayer personBussinessLayer;
        List<Person> person;
        Dictionary<String, Person> personDetail;
        int id;
        string name;
        string message;
        string path;

        public string AddPerson()
        {
            Console.WriteLine("Enter Person Name :");
            name = Input.StringInput();

            Console.WriteLine("Enter Mobile Id");
            id = Input.PositiveInteger();

            PersonBussinessLayer personBussinessLayer = new PersonBussinessLayer();
            Person addPerson = new Person(name, id);
            message = personBussinessLayer.AddPerson(addPerson);

            return message;
        }

        public string FetchData()
        {
            personBussinessLayer    = new PersonBussinessLayer();
            person                  = personBussinessLayer.FetchData();

            foreach (Person data in person)
            {
                Console.WriteLine("Person Id      :"+data.PersonId);
                Console.WriteLine("Person Name    :"+data.PersonName);
                Console.WriteLine("Mobile Oper Id :"+data.MobileOperatorId);
                writeToFile(data);
            }

            return "Completed";
        }

        private void writeToFile(Person data)
        {
            string path = @"D:\Person.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Person Id      :" + data.PersonId);
                    sw.WriteLine("Person Name    :" + data.PersonName);
                    sw.WriteLine("Mobile Oper Id :" + data.MobileOperatorId);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Person Id      :" + data.PersonId);
                    sw.WriteLine("Person Name    :" + data.PersonName);
                    sw.WriteLine("Mobile Oper Id :" + data.MobileOperatorId);
                }
            }
        }

        public string SearchById()
        {
            Console.WriteLine("Enter Person Id");   
            id = Input.PositiveInteger();

            personBussinessLayer   = new PersonBussinessLayer();
            personDetail           = personBussinessLayer.Search(id);

            try
            {
                if (0 == personDetail.Count)
                    throw new NoMobileOper("Nothing Match");
            }
            catch(Exception ex)
            {
                return "Sorry "+ex;
            }

            foreach (KeyValuePair<string,Person> item in personDetail)
            {
                Console.WriteLine("Mobile Operator  :" + item.Key);
                Console.WriteLine("Person Id  :" + item.Value.PersonId);
                Console.WriteLine("Person Name:" + item.Value.PersonName);
                Console.WriteLine("Mobile OperID :" + item.Value.MobileOperatorId);

            }
            /*
            foreach (var obj  in dict)
            {
               Console.WriteLine("Mobile Operator  :" + obj.Key);
               Console.WriteLine("Person Id  :" + obj.Value.PersonId);
               Console.WriteLine("Person Name:" + obj.Value.PersonName);
               Console.WriteLine("Mobile OperID :" + obj.Value.MobileOperatorId);
            }
            */

            return "Successfully Executed";
        }
    }
}

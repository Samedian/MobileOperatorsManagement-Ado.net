using DataAccessLayer;
using MobileOperator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class PersonBussinessLayer
    {
        public string AddPerson(Person person)
        {
            PersonDataAccessLayer personDataAccessLayer = new PersonDataAccessLayer();
            string msg = personDataAccessLayer.AddPersonDB(person);

            return msg;

        }

        public Dictionary<String,Person> Search(int id)
        {
            PersonDataAccessLayer personDataAccessLayer = new PersonDataAccessLayer();
            Dictionary<String, Person> dict = personDataAccessLayer.Search(id);

            return dict;
        }

        public List<Person> FetchData()
        {
            PersonDataAccessLayer personDataAccessLayer = new PersonDataAccessLayer();
            List<Person> list = personDataAccessLayer.Fetch();

            return list;
        }
    }
}

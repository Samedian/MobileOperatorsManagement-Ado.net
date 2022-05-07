using MobileOperator;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PersonDataAccessLayer
    { 
        public string AddPersonDB(Person person)
        {
            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = "Insert into Person Values ('" + person.PersonName + "'," + person.MobileOperatorId + ");";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                int row = sqlCommand.ExecuteNonQuery();

                return "Successfully Added one Row";
            }
            catch (Exception exception)
            {
                return "Something Went Wrong\n" + exception;
            }
        }

        public List<Person> Fetch()
        {
            List<Person> list = new List<Person>();
            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = "select * from Person ;";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person person = new Person();

                    person.PersonId = Convert.ToInt32(sqlDataReader[0]);
                    person.PersonName = sqlDataReader[1].ToString();
                    person.MobileOperatorId = int.Parse(sqlDataReader[2].ToString());
                    list.Add(person);
                   
                }

            }
            catch (Exception)
            {

            }

            return list;
        }

        public Dictionary<String, Person> Search(int id)
        {

            Dictionary<String, Person> dict = new Dictionary<string, Person>();
            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"Select * from Person inner join MobileOperatorDetail on Person.MobileOperatorId = MobileOperatorDetail.MobileOperId
                 and Person.PersonId ="+ id+";";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    Person person = new Person();
                    MobileOperatorCon mobileOperator = new MobileOperatorCon();

                    person.PersonId = Convert.ToInt32(sqlDataReader[0]);
                    person.PersonName = sqlDataReader[1].ToString();
                    person.MobileOperatorId = int.Parse(sqlDataReader[2].ToString());

                    mobileOperator.Name = sqlDataReader[4].ToString();

                    dict.Add(mobileOperator.Name, person);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return dict;
        }

    }
}

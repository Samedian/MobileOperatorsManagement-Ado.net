using MobileOperator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MobileDataAccessLayer
    {

        public string AddToDB(MobileOperatorCon mobileOperator)
        {
            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = "Insert into MobileOperatorDetail values ('" + mobileOperator.Name + "'," + mobileOperator.Rating + ");";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                int row = sqlCommand.ExecuteNonQuery();

                return "Successfully Added one Row";
            }catch(Exception exception)
            {
                return "Something Went Wrong\n" + exception;
            }
        }

        public List<MobileOperatorCon>  Display()
        {
            List<MobileOperatorCon> list = new List<MobileOperatorCon>();


            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = "Select MobileOperId,MobileOperName from MobileOperatorDetail";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while(dataReader.Read())
                {
                    MobileOperatorCon mobileOperatorCon = new MobileOperatorCon();

                    mobileOperatorCon.MobileOperatorId = Convert.ToInt32(dataReader[0]);
                    mobileOperatorCon.Name = dataReader[1].ToString();
                    list.Add(mobileOperatorCon);
                }
                
            }
            catch (Exception)
            {
               
            }

            return list;

        }

        public ArrayList Top2()
        {
            //List<MobileOperatorCon> list = new List<MobileOperatorCon>();
            ArrayList list = new ArrayList();

            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select rownum,MobileOperId,MobileOperName from( 
                               select row_number() over(order by Rating desc) as rownum,MobileOperId,MobileOperName 
                               ,Rating from MobileOperatorDetail)x where rownum <= 2";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    MobileOperatorCon mobileOperatorCon = new MobileOperatorCon();
                    mobileOperatorCon.MobileOperatorId = Convert.ToInt32(dataReader[1]);
                    mobileOperatorCon.Name = dataReader[2].ToString();
                    list.Add(mobileOperatorCon);
                }

            }
            catch (Exception)
            {

            }

            return list;

        }
    }
}

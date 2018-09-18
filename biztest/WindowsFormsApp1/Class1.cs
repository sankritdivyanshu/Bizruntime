using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Class1
    {

        static void Main(string[] args)
        {  // step1 connection string
            string conString = "Data Source = HP\\DIVYANSHUSQL; Initial Catalog = dumpi; Integrated Security = True";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                //step2 connection open
                conn.Open();
                //step3 build ur query
                string sqlQuery = "select * from emp1";

                SqlCommand command = new SqlCommand(sqlQuery, conn);

                SqlDataReader reader = command.ExecuteReader();
                     



            }

        }
         
    }
}

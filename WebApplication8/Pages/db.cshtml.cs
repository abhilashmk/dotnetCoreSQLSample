using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication8.Pages
{
    public class dbModel : PageModel
    {
        public string[] results = new string[2];
        public void OnGet()
        {
            try

            {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "dotnetsp.database.windows.net";

                builder.UserID = "abhilash";

                builder.Password = "Lssetup1!";

                builder.InitialCatalog = "dotnetSP";



                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))

                {

                    Console.WriteLine("\nQuery data example:");

                    Console.WriteLine("=========================================\n");



                    connection.Open();    // Here is the connection to the DB    

                    StringBuilder sb = new StringBuilder();

                    //With this you do a normal query 

                    sb.Append("select * from name1");

                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))

                    {

                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            int counter = 0;
                            while (reader.Read())

                            {
                                Console.WriteLine("{0}{1}", reader.GetInt32(0), reader.GetString(1));
                                results[counter] = reader.GetString(1);
                                counter++;
                            }

                        }

                    }

                }

            }

            catch (SqlException e)

            {

                Console.WriteLine(e.ToString());

            }
        }
    }
}

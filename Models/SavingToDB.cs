using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace List.Models
{
    internal class SavingToDB
    {
        public SavingToDB()
        {
           
        }


        public void Save(List<Employees> listaObjPracownikow)
        {
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employees;";
      
            string query = "SELECT * FROM employees";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    string[] row = { };
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        //row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        row.Append(reader.GetString(0));
                        Console.WriteLine(reader.GetString(0));
                    }
                    foreach (string d in row) { 
                        Console.WriteLine(d);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }


        }

        public List<Employees> Load()
        {
            
            List<Employees> listaObjPracownikow = new List<Employees>();

            

            return listaObjPracownikow;
        }

    }
}

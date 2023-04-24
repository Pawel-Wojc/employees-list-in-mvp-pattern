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
        private string _connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employees;";
        private string _query = "SELECT * FROM employees";
        
        public SavingToDB()
        {
           
        }


        public void Save(List<Employees> ListObjectsEmployees1)
        {
            //need to check in tha DB is the record or not, if not add, else dont --done
            List<Employees> ListObjectsEmployeesInDB = new List<Employees>();
            ListObjectsEmployeesInDB = Load();

            var ListObjectsEmployees = ListObjectsEmployees1.Except(ListObjectsEmployeesInDB);
            MySqlConnection databaseConnection = new MySqlConnection(_connectionString);
            MySqlDataReader reader;

            string _query_save = "";
            foreach (Employees obj in ListObjectsEmployees)
            {

                List<String> employee = new List<String>();
                employee = obj.StringList();

                _query_save = "INSERT INTO employees (Name, Surname, DateOfBirth, Salary, Position,ContractType) VALUES ('" + employee.ElementAt(0) + "',' " + employee.ElementAt(1) + "', '" + employee.ElementAt(2) + "', '" + employee.ElementAt(3) + "','" + employee.ElementAt(4) + "',' " + employee.ElementAt(5) + "')";

            }
            Console.WriteLine(_query_save);

            try {
                // Open the database
                
               
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(_query_save, databaseConnection);
                reader = commandDatabase.ExecuteReader();

            }catch(Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }




        }

        public List<Employees> Load()
        {

            List<Employees> ListObjectsEmployees = new List<Employees>();
            

            

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(_connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(_query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                
                if (reader.HasRows)
                {               
                    while (reader.Read())
                    {
                        List<string> data_employee = new List<string>();
                        for (int i = 0; i < 6; i++) { 
                            data_employee.Add(reader.GetString(i));
                           
                        }
                        var employess = new Employees(data_employee);

                        ListObjectsEmployees.Add(employess);
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

            return ListObjectsEmployees;
        }

    }
}

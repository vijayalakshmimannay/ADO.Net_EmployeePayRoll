// See https://aka.ms/new-console-template for more information

using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class PayrollService
    {
        public static string dbpath = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PayRoll;Integrated Security=True";
        SqlConnection connect = new SqlConnection(dbpath);
        //Fuction to check DB connection Establishment
        public void DatabaseConnection()
        {
            try
            {
                connect.Open();
                using (connect)
                {
                    Console.WriteLine("Database connectivity successful.");
                }
                connect.Close();
            }
            catch
            {
                Console.WriteLine("Database connectivity failed");
            }
        }
        public void GetAllEmployee()
        {
            ModelClass model = new ModelClass();
            using (connect)
            {
                string query = @"SELECT *from Employee_Payroll";

                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    Console.WriteLine("ID\t|\tNAME\t|\tSALARY\t\t|\tSTART\n-----------------");
                    while (reader.Read())
                    {
                        model.ID = reader.GetInt32(0);
                        model.NAME = reader.GetString(1);
                        model.SALARY = reader.GetDouble(2);
                        model.START = reader.GetDateTime(3);
                        Console.WriteLine(model.ID + "\t|\t" + model.NAME + "\t|\t" + model.SALARY + "\t|\t" + model.START);
                    }
                }
                else
                {
                    Console.WriteLine("Records not found in Database.");
                }
                reader.Close();

            }
            connect.Close();
        }

    }

}
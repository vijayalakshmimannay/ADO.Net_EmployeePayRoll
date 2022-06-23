// See https://aka.ms/new-console-template for more information

using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data;
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
            SqlConnection connect = new SqlConnection(dbpath);
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
        /*public bool AddEmployee(ModelClass model)
        {
            SqlConnection connect = new SqlConnection(dbpath);
            try
            {
                using (this.connect)
                {
                    SqlCommand cmd = new SqlCommand("Sp_Employee_Payroll", this.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NAME", model.NAME);
                    cmd.Parameters.AddWithValue("@SALARY", model.SALARY);
                    cmd.Parameters.AddWithValue("@START", model.START);
                    
                    this.connect.Open();
                    var result = cmd.ExecuteNonQuery();
                    this.connect.Close();
                    if(result != 0)
                    {
                        return true;
                    }
                    return false;
                   
                }
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.connect.Close();
            }
        }*/
        public void UpdateEmployee()
        {
            SqlConnection connect = new SqlConnection(dbpath);
            try
            {
                using (connect)
                {
                    Console.WriteLine("Enter name of employee to update basic pay:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter basic pay to uodate:");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());
                    connect.Open();
                    string query = "update employee_payroll set salary =" + salary + "where name='" + name + "'";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Records updated successfully.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError:Records are not updated.\n");
            }
        }
        public bool CreateEmployee()
        {
            SqlConnection connect = new SqlConnection(dbpath);

            using (connect)
            {
                SqlCommand cmd = new SqlCommand("Sp_Employee_Payroll", connect);
                ModelClass model = new ModelClass();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", model.NAME);
                cmd.Parameters.AddWithValue("@SALARY", model.SALARY);
                cmd.Parameters.AddWithValue("@START", model.START);

                connect.Open();
                var result = cmd.ExecuteNonQuery();
                this.connect.Close();
                if (result != 0)
                {
                    return true;
                }
                return false;

            }

        }

        public void DeleteEmployee()
        {
            SqlConnection connect = new SqlConnection(dbpath);
            using (connect)
            {
                connect.Open();
                Console.WriteLine("Enter name of employee to  delete from details:");
                string name = Console.ReadLine();
                string query = "delete from Employee_Payroll where NAME='" + name + "'";
                SqlCommand command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                connect.Close();
            }

        }

    }
}
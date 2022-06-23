// See https://aka.ms/new-console-template for more information

//EmployeePayroll.PayrollService payrollSystem = new EmployeePayroll.PayrollService();
//payrollSystem.DatabaseConnection();
using System;
namespace EmployeePayroll
{
    class program
    {
        public static void Main(string[] args)
        {
            EmployeePayroll.PayrollService value = new EmployeePayroll.PayrollService();
            ModelClass Model = new ModelClass();
            //value.DatabseConnection();
            //value.GetAllEmployee();

            /*Console.WriteLine("Enter Name");
            Model.NAME = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            Model.SALARY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Year,Month,Date");
            Model.START = Convert.ToDateTime(Console.ReadLine());*/
            //value.UpdateEmployee();
            value.GetAllEmployee();
           // value.CreateEmployee();
            value.DeleteEmployee();
        }
    }
}
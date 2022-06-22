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
            //value.DatabseConnection();
            value.GetAllEmployee();
        }
    }
}
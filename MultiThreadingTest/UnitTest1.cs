
using System.Collections.Generic;
using EmployeePayroll;

namespace MultiThreadingTest
{
    public class Tests
    {

        [Test]
        public void GivenListOfMultipleEmployee_AddIntoDataBase_TestTimeWithout_MutltiThreading()
        {
            List<ModelClass> modelclasses = new List<ModelClass>();
            modelclasses.Add(new ModelClass(ID: 10, NAME: "Lakshmi", SALARY: 30000, START: DateTime.Now, gender: "F", PHONENO: 9876567865, ADDRESS: "Hyderabad", DEPARTMENT: "NON-IT", BASIC_PAY: 21000, DEDUCTIONS: 1200, TAXCABLE_PAY: 1000, NET_PAY: 19000));
            modelclasses.Add(new ModelClass(ID: 11, NAME: "Harsha", SALARY: 35000, START: DateTime.Now, gender: "M", PHONENO: 8976546785, ADDRESS: "Banglore", DEPARTMENT: "Electrical", BASIC_PAY: 23000, DEDUCTIONS: 1400, TAXCABLE_PAY: 1300, NET_PAY: 21000));
            modelclasses.Add(new ModelClass(ID: 12, NAME: "Aarna", SALARY: 25000, START: DateTime.Now, gender: "F", PHONENO: 9856784536, ADDRESS: "Vijayawada", DEPARTMENT: "Mechanical", BASIC_PAY: 24000, DEDUCTIONS: 1500, TAXCABLE_PAY: 1400, NET_PAY: 22000));
            modelclasses.Add(new ModelClass(ID: 13, NAME: "Vijaya", SALARY: 30000, START: DateTime.Now, gender: "F", PHONENO: 9965478653, ADDRESS: "Kadapa", DEPARTMENT: "Sales", BASIC_PAY: 25000, DEDUCTIONS: 1600, TAXCABLE_PAY: 1500, NET_PAY: 23000));

            PayrollService payroll = new PayrollService();
            DateTime START = DateTime.Now;
            payroll.AddMultipleEmployees(modelclasses);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Time required to add multiple employees without using Thread: " + (endTime - START));
        }
    }
}
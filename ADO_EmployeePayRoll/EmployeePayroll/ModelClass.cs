// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class ModelClass
    {

        public int ID { get; set; }
        public string NAME { get; set; }
        public double SALARY { get; set; }
        public DateTime START { get; set; }
        public string gender { get; set; }
        public decimal PHONENO { get; set; }
        public string ADDRESS { get; set; }
        public string DEPARTMENT { get; set; }
        public double BASIC_PAY { get; set; }
        public double DEDUCTIONS { get; set; }
        public double TAXCABLE_PAY { get; set; }
        public double NET_PAY { get; set; }



        public ModelClass(int ID, string NAME, double SALARY, DateTime START, string gender, decimal PHONENO, string ADDRESS, string DEPARTMENT, double BASIC_PAY, double DEDUCTIONS, double TAXCABLE_PAY, double NET_PAY)
        {
            this.ID = ID;
            this.NAME = NAME;
            this.SALARY = SALARY;
            this.START = START;
            this.gender = gender;
            this.PHONENO = PHONENO;
            this.ADDRESS = ADDRESS;
            this.DEPARTMENT = DEPARTMENT;
            this.BASIC_PAY = BASIC_PAY;
            this.DEDUCTIONS = DEDUCTIONS;
            this.TAXCABLE_PAY = TAXCABLE_PAY;
            this.NET_PAY = NET_PAY;

        }
    }

}

   

// See https://aka.ms/new-console-template for more information

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
    }
}
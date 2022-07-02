using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;

namespace RestSharpTestCase
{
    public class Employee
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SALARY { get; set; }
    }
    [TestClass]
    public class RESTSharp
    {
        RestClient client;

        /*[TestMethod]
        public void OnCallingGetMethod_CompareCount_ShouldReturnEmployeeList()
        {
            client = new RestClient("http://localhost:4000");
            //Arrange
            RestRequest request = new RestRequest("/Employee", Method.Get);
            //Act
            RestResponse response = client.Execute(request);
            //Assert
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            List<Employee> list = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(40, list.Count);
            foreach (Employee value in list)
            {
                Console.WriteLine("Id:" + value.ID + ",\t " + value.NAME + ",\t " + value.SALARY);
            }
        }
        [TestMethod]
        public void OnPostingEmployeeData_AddtoJsonServer_ReturnRecentlyAddedData()
        {
            client = new RestClient("http://localhost:4000");
            //Arrange
            RestRequest request = new RestRequest("/Employee", Method.Post);
            var body = new Employee { NAME = "Sita", SALARY = "30000" };
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            //Act
            RestResponse response = client.Execute(request);
            //Assert
            Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
            Employee value = JsonConvert.DeserializeObject<Employee>(response.Content);
            Assert.AreEqual("Sita", value.NAME);
            Assert.AreEqual("30000", value.SALARY);
            Console.WriteLine(response.Content);
        }*/
        /*[TestMethod]
        public void OnPostingMultipleEmployees_AddToJsonServer_ReturnListOfAddedData()
        {
            client = new RestClient("http://localhost:4000");
            //Arrange
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { NAME = "Ramesh", SALARY = "25000" });
            list.Add(new Employee { NAME = "Jyothi", SALARY = "35000" });
            list.Add(new Employee { NAME = "Karuna", SALARY = "45000" });
            list.ForEach(body =>
            {
                RestRequest request = new RestRequest("/Employee", Method.Post);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                //Act
                RestResponse response = client.Execute(request);
                //Assert
                Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
                Employee value = JsonConvert.DeserializeObject<Employee>(response.Content);
                Assert.AreEqual(body.NAME, value.NAME);
                Assert.AreEqual(body.SALARY, value.SALARY);
                Console.WriteLine(response.Content);
            });
        }*/
        [TestMethod]
        public void OnUpdatingEmployeeData_ShouldUpdateValueInJsonServer()
        {
            client = new RestClient("http://localhost:4000");
            //Arrange
            RestRequest request = new RestRequest("/Employee/8", Method.Put);
            List<Employee> list = new List<Employee>();
            Employee body = new Employee { NAME = "Aarna", SALARY = "50000" };
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            //Act
            RestResponse response = client.Execute(request);
            //Assert
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            Employee value = JsonConvert.DeserializeObject<Employee>(response.Content);
            Assert.AreEqual("Aarna", value.NAME);
            Assert.AreEqual("50000", value.SALARY);
            Console.WriteLine(response.Content);
        }
    }
}



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

        [TestMethod]
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
            Assert.AreEqual(5, list.Count);
            foreach (Employee value in list)
            {
                Console.WriteLine("Id:" + value.ID + ",\t " + value.NAME + ",\t " + value.SALARY);
            }
        }
    }
}

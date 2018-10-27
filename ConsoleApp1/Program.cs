using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;

namespace ConsoleApp1
{
    public class Program
    {
        public void Main(string[] args)
        {
        Start:
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            string apiUrl = "http://localhost:53832/HOSTAPI/api/credit/5";
            var input = new
            {
                Name = name,
            };
            string inputJson = (new JavaScriptSerializer()).Serialize(input);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
          //  client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl + "/GetCustomers", inputJson);
            List<Customer> customers = (new JavaScriptSerializer()).Deserialize<List<Customer>>(json);
            if (customers.Count > 0)
            {
                foreach (Customer customer in customers)
                {
                    Console.WriteLine(customer.ContactName);
                }
            }
            else
            {
                Console.WriteLine("No records found.");
            }
            Console.WriteLine();
            goto Start;
        }
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
    }
}

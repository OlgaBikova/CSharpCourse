using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using System.Xml.Serialization;
using WEBApiExample2.Models;

namespace WEBApiExample2.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<EmployeeModel> EmployeeGet()
        {
            return GetEmployeeListFromXml();
            //return GetEmployeeList();
        }
              
        // GET: api/Employee/5
        [HttpGet]
        public IEnumerable<EmployeeModel> Get(int id)
        {
            var employeeList = GetEmployeeListFromXml();

            return employeeList.Where(x => x.Id == id);
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody]EmployeeModel employee)
        {
            var fullPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_data/EmployeeList.xml");

            XElement xElement = new XElement("EmployeeModel",
                new XElement("Id", employee.Id),
                new XElement("Name", employee.Name),
                new XElement("Surname", employee.Surname),
                new XElement("Age", employee.Age));

            var existingXmlDocument = XDocument.Load(fullPath);
            existingXmlDocument.Root.Add(xElement);
            existingXmlDocument.Save(fullPath);
        }

        // PUT: api/Employee/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        [HttpDelete]
        public void DeleteEmployeeRecord(int id)
        {
        }

        private List<EmployeeModel> GetEmployeeList()
        {
            var employeeList = new List<EmployeeModel>();

            var employee1 = new EmployeeModel() { Id = 1, Name = "Tom", Surname = "Johnos", Age = 23 };
            var employee2 = new EmployeeModel() { Id = 2, Name = "Bill", Surname = "Gates", Age = 45 };
            var employee3 = new EmployeeModel() { Id = 3, Name = "Kate", Surname = "Svenson", Age = 65 };
            var employee4 = new EmployeeModel() { Id = 4, Name = "Lisa", Surname = "Olson", Age = 21 };

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);

            return employeeList;
        }

        private List<EmployeeModel> GetEmployeeListFromXml()
        {
            var fullPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_data/EmployeeList.xml");

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "EmployeeList";

            XmlSerializer serializer = new XmlSerializer(typeof(List<EmployeeModel>), xRoot);

            System.IO.StreamReader reader = new System.IO.StreamReader(fullPath);

            var employeeList = (List<EmployeeModel>)serializer.Deserialize(reader);

            reader.Close();
            return employeeList;
        }
    }
}

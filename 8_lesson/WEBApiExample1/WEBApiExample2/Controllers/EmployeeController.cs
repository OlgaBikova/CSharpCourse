using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBApiExample2.Models;

namespace WEBApiExample2.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<EmployeeModel> EmployeeGet()
        {
            return GetEmployeeList();
        }
              
        // GET: api/Employee/5
        [HttpGet]
        public IEnumerable<EmployeeModel> Get(int id)
        {
            var employeeList = GetEmployeeList();

            return employeeList.Where(x => x.Id == id);
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
    }
}

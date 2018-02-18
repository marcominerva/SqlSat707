using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var data = NorthwindData.Northwind.LoadEmployeesFromDatabase();

            var results = data.Select().Select(d => new
            {
                EmployeeId = Convert.ToInt32(d["EmployeeID"]),
                FirstName = d["FirstName"].ToString(),
                LastName = d["LastName"].ToString(),
                Title = d["Title"].ToString()
            });

            return Ok(results);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

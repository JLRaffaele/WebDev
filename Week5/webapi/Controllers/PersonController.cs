
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return getPersons();
            //return new string[] { "value1", "value2" };
        }

        private List<Person> getPersons()
        {
            return InMemory.persons;
        }

        // POST api/persons
        [HttpPost]
        public void Post([FromBody] Person person)
        {
            person.personID = getNextPerson();

            InMemory.persons.Add(person);
        }

        private int getNextPerson()
        {
            return InMemory.persons.Max(p => p.personID) + 1;
        }
    }
}
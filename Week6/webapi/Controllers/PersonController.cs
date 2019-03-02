using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public PersonController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Person>> GetAllPersons()
        {
            return Ok(_dbContext.Person.Include(p => p.Student).ToList());
        }

        [HttpGet("{personId}")]
        public ActionResult<Person> GetPerson(int personId)
        {
            var person = _dbContext.Person
                .SingleOrDefault(p => p.personId == personId);

            if (person != null) {
                return person;
            } else {
                return NotFound();
            }
        }
/*
        [HttpPost]
        public ActionResult<Person> AddPerson(Person person)
        {
            _dbContext.Person.Add(person);
            _dbContext.SaveChanges();

            // return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{personId}")]
        public ActionResult DeletePerson(int personId)
        {
            var person = new Person { personId = personId };

            _dbContext.Person.Attach(person);
            _dbContext.Person.Remove(person);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{personId}")]
        public ActionResult UpdatePerson(int personId, Person personUpdate)
        {
            var person = _dbContext.Person
                .SingleOrDefault(p => p.personId == personId);

            if (person != null)
            {
                person.first_name = personUpdate.first_name;
                person.middle_name = personUpdate.middle_name;
                person.last_name = personUpdate.last_name;

                _dbContext.Update(person);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
        */
    }
    
}
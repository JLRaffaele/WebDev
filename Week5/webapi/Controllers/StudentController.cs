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
    public class StudentController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return getStudents();
        }

        private List<Student> getStudents()
        {
            return InMemory.students;
        }

        // POST api/students
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            student.studentID = getNextID();

            InMemory.students.Add(student);
        }

        private int getNextID()
        {
            return InMemory.students.Max(s => s.studentID) + 1;
        }

        
    }
}

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
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(_dbContext.Student.Include(p => p.Person).ToList());
        }   
        /*
        [HttpGet("{studentId}")]
        public ActionResult<Student> GetStudent(int studentId)
        {
            var student = _dbContext.Students
                .SingleOrDefault(p => p.studentId == studentId);

            if (student != null) {
                return student;
            } else {
                return NotFound();
            }
        }
        */
    }
}
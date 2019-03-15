using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Database.Entities;
using StudentBusinessRules;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRespository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRespository = studentRepository;
    }

    public List<StudentDto> GetAllStudents()
    {
        var studentDtos = new List<StudentDto>();

        foreach(var student in _studentRespository.GetAllStudents())
        {
            studentDtos.Add(new StudentDto {
                StudentId = student.studentId,
                email_address = student.email_address,
                Special = BusinessRules.isSpecial(student)
            });
            if (BusinessRules.isSpecial(student))
            {
              
            }
        }

        return studentDtos;
    }
}
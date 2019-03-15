using System.Collections.Generic;
using Database.Entities;

public interface IStudentService
{
    List<StudentDto> GetAllStudents();

}
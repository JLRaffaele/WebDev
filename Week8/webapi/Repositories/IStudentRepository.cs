using System.Collections.Generic;
using Database.Entities;

public interface IStudentRepository
{
    List<Student> GetAllStudents();
}
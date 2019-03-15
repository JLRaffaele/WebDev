using System;
using Database.Entities;

namespace StudentBusinessRules {
    public static class BusinessRules
    {
        public static bool isSpecial(Student student) => 
            student.studentId == 1;

        
    }
}
using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> students = new List<Student> {
            new Student {
                studentID = 1,
                email = "test@test.com"
            },
            new Student {
                studentID = 2,
                email = "test2@test.com"
            },
        };

        public static List<Person> persons = new List<Person> {
            new Person {
                personID = 1,
                firstname = "bob",
                lastname = "vance",
                middleinitial = "F"
            },
            new Person {
                personID = 2,
                firstname = "jim",
                lastname = "halpert",
                middleinitial = "D"
            },
        };
    }
}
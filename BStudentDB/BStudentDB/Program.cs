using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BStudentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {
                // Create a new student
                var newStudent = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                // Add the student to the database
                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("Student added to the database.");
            }
        }
    }
}

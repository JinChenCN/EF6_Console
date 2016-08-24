using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var courses = new List<Course>
                {
                    new Course { CourseName = "Art"},
                    new Course { CourseName = "Math"}
                };

                courses.ForEach(c => ctx.Courses.Add(c));
                ctx.SaveChanges();

                var stud = new Student() { StudentName = "test", Address = new StudentAddress() { Country = "China"}, Courses = courses };
                ctx.Students.Add(stud);
                ctx.SaveChanges();

                var student = ctx.Students.Find(5);
                Console.WriteLine(student.StudentName);
                Console.WriteLine(student.Address.Country);
                Console.WriteLine(student.Courses.Count);

                Console.ReadKey();
            }

        }
    }
}

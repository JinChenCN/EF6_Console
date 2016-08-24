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
                Student stud = new Student() { StudentName = "test", Address = new StudentAddress()};
                ctx.Students.Add(stud);
                ctx.SaveChanges();

                var student = ctx.Students.FirstOrDefault();
                Console.WriteLine(student.StudentName);
                Console.WriteLine(student.Address.StudentAddressId);
            }

        }
    }
}

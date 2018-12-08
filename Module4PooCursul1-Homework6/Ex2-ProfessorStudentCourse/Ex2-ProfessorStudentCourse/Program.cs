using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ProfessorStudentCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Professor("Vasilica", "Alexandru Ioan-Cuza", "Info");
           
            Console.WriteLine(p1.Print());

            Student s1 = new Student("Mirabela", "Info", 2);
            Console.WriteLine(s1.Print());

            Student s2= new Student("Lili", "Info", 3);
            var listOfStudents = new List<Student>();
            listOfStudents.Add(s1);
            listOfStudents.Add(s2);

            Course c1 = new Course("Programarea algoritmilor",p1,1,listOfStudents);
            Console.WriteLine(c1.Print());
            foreach(var elem in listOfStudents)
            {
                Console.WriteLine(elem.Name);
            }
            Console.ReadKey();

            
        }
    }
}

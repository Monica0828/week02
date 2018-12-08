using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ProfessorStudentCourse
{
    class Course
    {
        public Course(string name, Professor p1, int year, List<Student> listOfStudents)
        {
            Name = name;
            Professor = p1;
            Year = year;
            ListOfStudents = listOfStudents;
        }
        public string Name { get; }

        public Professor Professor { get; }

        public int Year { get; }
        
        public List<Student> ListOfStudents { get; set; }

        public string Print()
        {
            return $"Name of the course is: {Name}, the professor is: {Professor.Name}. " +
                $"This course is in year {Year}, and the students are: ";
        }

    }
}

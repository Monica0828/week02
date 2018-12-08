using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ProfessorStudentCourse
{
    class Student
    {

        public Student(string name, string faculty, int year)
        {
            Name = name;
            Faculty = faculty;
            Year = year;
        }

        public string Name { get; }

        public string Faculty { get; }

        public int Year { get; }

        public string Print()
        {
            return $"{Name} is studying at {Faculty}, and is in year: {Year}.";
        }
    }
}

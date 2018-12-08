using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ProfessorStudentCourse
{
    class Professor
    {
        public Professor(string name, string faculty, string specialization)
        {
            Name = name;
            Faculty = faculty;
            Specialization = specialization;
        }
        public string Name { get; set; }

        public string Faculty { get; set; }

        public string Specialization { get; set; }

        public string Print()
        {
            return $"{Name} is teaching at {Faculty}, specialization {Specialization}.";
        }
    }
}
